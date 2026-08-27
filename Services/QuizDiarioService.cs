using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.QuizDiario.Detalhe;
using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizDiario.Resultado;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Questoes;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Services
{
    public class QuizDiarioService
    {
        public async Task<QuizDiarioDetalhes?> CriarQuizDiario()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var questaoAvancada = contexto.Questoes
                .Where(q => q.NivelId == QuestaoNivelId.Avancado)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .OrderBy(q => EF.Functions.Random())
                .FirstOrDefault();

            var questoes = questaoAvancada != null ? new List<Questao> { questaoAvancada } : new List<Questao>();

            int? idAvancada = questaoAvancada?.Id;

            var questoesAleatorias = await contexto.Questoes
                .Where(q => q.Id != idAvancada)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
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

        public async Task<QuizDiarioDetalhes?> ObterQuizDiario()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioDetalhes?> ObterDetalhePorId(int quizId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioResultado?> ObterResultadoPorId(int quizId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .QuizResultado()
                .FirstOrDefaultAsync();
        }

        public async Task<List<QuizDiarioHistorico>> ObterTodosHistoricos()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .QuizHistorico()
                .ToListAsync();
        }

        public async Task<List<QuizDiarioHistorico>> ObterHistoricosRecentes(int quantidade)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .OrderByDescending(quiz => quiz.DataInicio)
                .Take(quantidade)
                .QuizHistorico()
                .ToListAsync();
        }

        public async Task<bool> SalvarResposta(int quizId, int questaoId, bool ehCorreta, int sequenciaAcertos)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            UsuarioStats? usuarioStats = await contexto.Usuarios
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => usuario.Stats)
                .FirstOrDefaultAsync();

            if (usuarioStats == null) throw new Exception();

            int questaoValor = await contexto.Questoes
                .Where(questao => questao.Id == questaoId)
                .Select(questao => questao.Nivel.Valor)
                .FirstOrDefaultAsync();

            // Em porcentagem (0%)
            int bonus = 0;

            int pontuacaoFinal = 0;

            if (sequenciaAcertos >= 5) bonus = 20;
            else if (sequenciaAcertos < 3) bonus = 10;
            else bonus = 0;

            if (ehCorreta == true) pontuacaoFinal = questaoValor + (questaoValor * bonus) / 100;

            var resposta = new UsuarioResposta
            {
                QuizId = quizId,
                UsuarioId = usuarioId,
                QuestaoId = questaoId,
                QuestaoValor = questaoValor,
                Acertou = ehCorreta,
                PontuacaoFinal = pontuacaoFinal
            };

            contexto.UsuarioRespostas.Add(resposta);
            usuarioStats.AdicionarPontos(pontuacaoFinal);
            usuarioStats.AtualizarAcertos(ehCorreta);
            await contexto.SaveChangesAsync();

            return ehCorreta;
        }

        public async Task<bool> SalvarRespostaAlternativa(int quizId, int questaoId, int alternativaId, int sequenciaAcertos)
        {
            using var contexto = new QuizAppContexto();

            bool ehCorreta = await contexto.Alternativas
                .Where(alternativa => alternativa.Id == alternativaId)
                .Select(alternativa => alternativa.EhCorreta)
                .FirstOrDefaultAsync();

            return await SalvarResposta(quizId, questaoId, ehCorreta, sequenciaAcertos);
        }

        public async Task<bool> SalvarRespostaVerdadeiroFalso(int quizId, int questaoId, bool verdadeiroFalso, int sequenciaAcertos)
        {
            using var contexto = new QuizAppContexto();

            bool ehCorreta = await contexto.Questoes
                .Where(questao => questao.Id == questaoId)
                .Select(questao => questao.VerdadeiroFalso)
                .FirstOrDefaultAsync() ?? false;

            return await SalvarResposta(quizId, questaoId, ehCorreta, sequenciaAcertos);
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
        }
    }

    public static class QuizQueryExtensoes
    {
        public static IQueryable<QuizDiario> QuizDadosCompletos(this IQueryable<QuizDiario> query)
        {
            return query
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Tema)
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Nivel)
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Tipo)
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Alternativas)
                .Include(quiz => quiz.UsuarioRespostas)
                .AsSplitQuery();
        }

        public static IQueryable<QuizDiarioDetalhes> QuizDetalhes(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizDiarioDetalhes
                {
                    Id = quiz.Id,
                    DataExibido = quiz.DataExibido,
                    FoiConcluido = quiz.FoiConcluido,
                    PontuacaoTotal = quiz.PontuacaoTotal,

                    Questoes = quiz.Questoes
                        .Select(questao => new QuizDiarioDetalhesQuestao
                        {
                            Id = questao.Id,
                            Enunciado = questao.Enunciado,
                            TemaId = questao.TemaId,
                            Tema = questao.Tema.Nome,
                            NivelId = questao.NivelId,
                            Nivel = questao.Nivel.Nome,
                            TipoId = questao.TipoId,
                            Tipo = questao.Tipo.Nome,
                            Pontos = questao.Nivel.Valor,

                            Respondida = quiz.UsuarioRespostas
                                .Any(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuestaoId == questao.Id),

                            Acertou = quiz.UsuarioRespostas
                                .Where(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuestaoId == questao.Id)
                                .Select(resposta => (bool?)resposta.Acertou)
                                .FirstOrDefault(),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new QuizDiarioDetalhesAlternativa
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto
                            }).ToList(),
                    }).ToList()
                });
        }

        public static IQueryable<QuizDiarioResultado> QuizResultado(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizDiarioResultado
                {
                    Id = quiz.Id,
                    DataInicio = quiz.DataInicio,
                    DataExibido = quiz.DataExibido,
                    DataConcluido = quiz.DataConcluido,
                    TempoDeConclusao = quiz.TempoDeConclusao,

                    TotalQuestoes = quiz.Questoes
                        .Count(),

                    TotalAcertos = quiz.UsuarioRespostas
                        .Count(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.Acertou),

                    PontuacaoTotal = quiz.PontuacaoTotal,

                    Questoes = quiz.Questoes
                        .Select(questao => new QuizDiarioResultadoQuestao
                        {
                            Id = questao.Id,
                            Enunciado = questao.Enunciado,
                            TemaId = questao.TemaId,
                            Tema = questao.Tema.Nome,
                            NivelId = questao.NivelId,
                            Nivel = questao.Nivel.Nome,
                            TipoId = questao.TipoId,
                            Tipo = questao.Tipo.Nome,
                            Pontos = questao.Nivel.Valor,

                            Acertou = quiz.UsuarioRespostas
                                .Where(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuizId == quiz.Id && resposta.QuestaoId == questao.Id)
                                .Select(resposta => resposta.Acertou)
                                .FirstOrDefault(),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new QuizDiarioResultadoAlternativa
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto,
                                Correta = alternativa.EhCorreta
                            }).ToList(),
                    }).ToList()
                });
        }

        public static IQueryable<QuizDiarioHistorico> QuizHistorico(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizDiarioHistorico
                {
                    Id = quiz.Id,
                    DataInicio = quiz.DataInicio,
                    DataExibido = quiz.DataExibido,
                    DataConcluido = quiz.DataConcluido,
                    TempoDeConclusao = quiz.TempoDeConclusao,

                    TotalQuestoes = quiz.Questoes
                        .Count(),

                    TotalAcertos = quiz.UsuarioRespostas
                        .Count(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.Acertou),

                    PontuacaoTotal = quiz.PontuacaoTotal,

                    Questoes = quiz.Questoes
                        .Select(questao => new QuizDiarioHistoricoQuestao
                        {
                            Id = questao.Id,
                            Enunciado = questao.Enunciado,
                            TemaId = questao.TemaId,
                            Tema = questao.Tema.Nome,
                            NivelId = questao.NivelId,
                            Nivel = questao.Nivel.Nome,
                            TipoId = questao.TipoId,
                            Tipo = questao.Tipo.Nome,
                            Pontos = questao.Nivel.Valor,

                            Acertou = quiz.UsuarioRespostas
                                .Where(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuizId == quiz.Id && resposta.QuestaoId == questao.Id)
                                .Select(resposta => resposta.Acertou)
                                .FirstOrDefault(),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new QuizDiarioHistoricoAlternativa
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto,
                                Correta = alternativa.EhCorreta
                            }).ToList(),
                    }).ToList()
                });
        }
    }
}
