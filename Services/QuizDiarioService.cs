using AntdUI;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Historico;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Questoes;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Services
{
    public class QuizDiarioService
    {
        private readonly ConquistaService _conquistaService;

        public QuizDiarioService(ConquistaService conquistaService)
        {
            _conquistaService = conquistaService;
        }

        public async Task<QuizDiarioTentativa?> CriarQuizDiario()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var questaoAvancada = contexto.Questoes
                .Where(q => q.NivelId == QuestaoNivelId.Avancado)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Alternativas)
                .OrderBy(q => EF.Functions.Random())
                .FirstOrDefault();

            var questoes = questaoAvancada != null ? new List<Questao> { questaoAvancada } : new List<Questao>();

            int? idAvancada = questaoAvancada?.Id;

            var questoesAleatorias = await contexto.Questoes
                .Where(q => q.Id != idAvancada)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Alternativas)
                .OrderBy(q => EF.Functions.Random())
                .Take(9)
                .ToListAsync();

            questoes.AddRange(questoesAleatorias);

            var agoraLocal = ObterHora.ObterHoraBrasilia();
            var hoje = DateOnly.FromDateTime(agoraLocal);

            QuizDiario novoQuiz = new()
            {
                UsuarioId = usuarioId,
                DataExibido = hoje,
                Questoes = questoes
            };

            contexto.QuizzesDiarios.Add(novoQuiz);
            await contexto.SaveChangesAsync();

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioTentativa?> ObterQuizDiario()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioTentativa?> ObterDetalhePorId(int quizId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioCompleto?> ObterResultadoPorId(int quizId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .QuizResultado()
                .FirstOrDefaultAsync();
        }
        public async Task<QuizRushEntrada?> ObterResultadorUSHPorId(int quizId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesRush
                .Where(quiz => quiz.Id == quizId)
                .Select(quiz => new QuizRushEntrada
                {
                    Id = quiz.Id,
                    DataIniciado = quiz.DataIniciado,
                    DataConcluido = quiz.DataConcluido,
                    Tempo = quiz.Tempo,
                    Streak = quiz.Streak,
                    PontuacaoTotal = quiz.PontuacaoTotal
                })
                .FirstOrDefaultAsync();
        }

        public async Task<bool?> SalvarResposta(int quizId, int questaoId, bool ehCorreta, int sequenciaAcertos, int? alternativaId = null, bool? verdadeiroFalso = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            UsuarioStats? usuarioStats = await contexto.Usuarios
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => usuario.Stats)
                .FirstOrDefaultAsync();

            if (usuarioStats == null) throw new Exception();

            var questao = await contexto.Questoes
                .Where(questao => questao.Id == questaoId)
                .Select(questao => new
                {
                    TemaId = questao.TemaId,
                    Valor = questao.Nivel.Valor
                })
                .FirstOrDefaultAsync();

            int? quizSequenciaAcertos = await contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .Select(quiz => quiz.MaxAcertosSeguidos)
                .FirstOrDefaultAsync();

            if (questao == null || quizSequenciaAcertos == null) return null;

            // Em porcentagem (0%)
            int bonus = 0;

            int pontuacaoFinal = 0;

            if (sequenciaAcertos >= 5) bonus = 20;
            else if (sequenciaAcertos < 3) bonus = 10;
            else bonus = 0;

            if (ehCorreta == true) pontuacaoFinal = questao.Valor + (questao.Valor * bonus) / 100;

            if (sequenciaAcertos > quizSequenciaAcertos) quizSequenciaAcertos = sequenciaAcertos;

            var resposta = new UsuarioResposta
            {
                QuizId = quizId,
                UsuarioId = usuarioId,
                QuestaoId = questaoId,
                QuestaoValor = questao.Valor,
                AlternativaId = alternativaId,
                VerdadeiroFalso = verdadeiroFalso,
                Acertou = ehCorreta,
                PontuacaoFinal = pontuacaoFinal
            };

            contexto.UsuarioRespostas.Add(resposta);
            usuarioStats.AtualizarAcertos(ehCorreta);

            if (ehCorreta)
            {
                usuarioStats.AdicionarPontos(pontuacaoFinal);

                var temaProgresso = await contexto.UsuarioTemasProgressos
                    .SingleOrDefaultAsync(p => p.UsuarioId == usuarioId && p.TemaId == questao.TemaId);

                if (temaProgresso == null)
                {
                    temaProgresso = new UsuarioTemasProgresso
                    {
                        UsuarioId = usuarioId,
                        TemaId = questao.TemaId,
                        RespostasCorretas = 1
                    };

                    contexto.UsuarioTemasProgressos.Add(temaProgresso);
                }
                else
                {
                    temaProgresso.RespostasCorretas++;
                }
            }

            await contexto.SaveChangesAsync();
            await _conquistaService.ChecarQuizConquistas();

            return ehCorreta;
        }

        public async Task<bool?> SalvarRespostaAlternativa(int quizId, int questaoId, int alternativaId, int sequenciaAcertos)
        {
            using var contexto = new QuizAppContexto();

            bool ehCorreta = await contexto.Alternativas
                .Where(alternativa => alternativa.Id == alternativaId)
                .Select(alternativa => alternativa.EhCorreta)
                .FirstOrDefaultAsync();

            return await SalvarResposta(quizId, questaoId, ehCorreta, sequenciaAcertos, alternativaId: alternativaId);
        }

        public async Task<bool?> SalvarRespostaVerdadeiroFalso(int quizId, int questaoId, bool verdadeiroFalso, int sequenciaAcertos)
        {
            using var contexto = new QuizAppContexto();

            bool ehCorreta = await contexto.Questoes
                .Where(questao => questao.Id == questaoId)
                .Select(questao => questao.VerdadeiroFalso == verdadeiroFalso)
                .FirstOrDefaultAsync();

            return await SalvarResposta(quizId, questaoId, ehCorreta, sequenciaAcertos, verdadeiroFalso: verdadeiroFalso);
        }

        public async Task ConcluirQuiz(int quizId)
        {
            using var contexto = new QuizAppContexto();

            QuizDiario? quiz = await contexto.QuizzesDiarios
                .Include(quiz => quiz.UsuarioRespostas)
                .FirstOrDefaultAsync(quiz => quiz.Id == quizId);

            if (quiz == null) return;

            int pontuacaoReal = quiz.UsuarioRespostas
                .Where(resposta => resposta.Acertou)
                .Sum(resposta => resposta.PontuacaoFinal);

            quiz.Concluir(pontuacaoReal);
            await contexto.SaveChangesAsync();

            await _conquistaService.ChecarQuizConquistas();
        }
    }

    public static class QuizQueryExtensoes
    {
        public static IQueryable<QuizDiarioTentativa> QuizDetalhes(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizDiarioTentativa
                {
                    Id = quiz.Id,
                    DataExibido = quiz.DataExibido,
                    FoiConcluido = quiz.Concluido,
                    PontuacaoTotal = quiz.PontuacaoTotal,

                    Questoes = quiz.Questoes
                        .Select(questao => new QuestaoExibicao
                        {
                            Id = questao.Id,
                            Enunciado = questao.Enunciado,
                            TemaId = questao.TemaId,
                            Tema = questao.Tema.Nome,
                            NivelId = questao.NivelId,
                            Nivel = questao.Nivel.Nome,
                            Tipo = questao.Tipo,
                            Pontos = questao.Nivel.Valor,

                            Respondida = quiz.UsuarioRespostas
                                .Any(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuestaoId == questao.Id),

                            Acertou = quiz.UsuarioRespostas
                                .Where(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuestaoId == questao.Id)
                                .Select(resposta => (bool?)resposta.Acertou)
                                .FirstOrDefault(),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new AlternativaExibicao
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto
                            }).OrderBy(a => EF.Functions.Random()).ToList(),
                    }).ToList()
                });
        }

        public static IQueryable<QuizDiarioCompleto> QuizResultado(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizDiarioCompleto
                {
                    Id = quiz.Id,
                    DataIniciado = quiz.DataIniciado,
                    DataExibido = quiz.DataExibido,
                    DataConcluido = quiz.DataConcluido,
                    TempoDeConclusao = quiz.TempoDeConclusao,

                    TotalQuestoes = quiz.Questoes
                        .Count(),

                    TotalAcertos = quiz.UsuarioRespostas
                        .Count(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.Acertou),

                    PontuacaoTotal = quiz.PontuacaoTotal,

                    Questoes = quiz.Questoes
                        .Select(questao => new QuestaoRespondida
                        {
                            Id = questao.Id,

                            TemaId = questao.TemaId,
                            Tema = questao.Tema.Nome,

                            NivelId = questao.NivelId,
                            Nivel = questao.Nivel.Nome,

                            Tipo = questao.Tipo,

                            Enunciado = questao.Enunciado,
                            Pontos = questao.Nivel.Valor,
                            Acertou = quiz.UsuarioRespostas
                                .Any(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuestaoId == questao.Id && resposta.Acertou),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new AlternativaCorreta
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto,
                                Correta = alternativa.EhCorreta
                            }).ToList(),

                            VerdadeiroFalso = questao.VerdadeiroFalso
                    }).ToList()
                });
        }
    }
}
