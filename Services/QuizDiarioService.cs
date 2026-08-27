using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.QuizDiario.Detalhe;
using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizDiario.Resultado;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Services
{
    public class QuizDiarioService
    {
        private readonly QuizAppContexto _contexto;

        public QuizDiarioService(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<QuizDiarioDetalhes?> CriarQuizDiario()
        {
            int usuarioId = UsuarioAtual.Id;

            var questaoAvancada = _contexto.Questoes
                .Where(q => q.NivelId == QuestaoNivelId.Avancado)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .OrderBy(q => Guid.NewGuid())
                .FirstOrDefault();

            var questoes = questaoAvancada != null ? new List<Questao> { questaoAvancada } : new List<Questao>();

            int? idAvancada = questaoAvancada?.Id;

            var questoesAleatorias = await _contexto.Questoes
                .Where(q => q.Id != idAvancada)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .OrderBy(q => Guid.NewGuid())
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

            _contexto.QuizzesDiarios.Add(novoQuiz);
            await _contexto.SaveChangesAsync();

            return await _contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioDetalhes?> ObterQuizDiario()
        {
            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            return await _contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioDetalhes?> ObterDetalhePorId(int quizId)
        {
            return await _contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .QuizDetalhes()
                .FirstOrDefaultAsync();
        }

        public async Task<QuizDiarioResultado?> ObterResultadoPorId(int quizId)
        {
            return await _contexto.QuizzesDiarios
                .Where(quiz => quiz.Id == quizId)
                .QuizResultado()
                .FirstOrDefaultAsync();
        }

        public async Task<List<QuizDiarioHistorico>> ObterTodosHistoricos()
        {
            return await _contexto.QuizzesDiarios
                .QuizHistorico()
                .ToListAsync();
        }

        public async Task<List<QuizDiarioHistorico>> ObterHistoricosRecentes(int quantidade)
        {
            return await _contexto.QuizzesDiarios
                .OrderByDescending(quiz => quiz.DataInicio)
                .Take(quantidade)
                .QuizHistorico()
                .ToListAsync();
        }

        public async Task ConcluirQuiz(int quizId)
        {
            QuizDiario? quiz = await _contexto.QuizzesDiarios
                .FindAsync(quizId);

            if (quiz == null) return;

            quiz.Concluir();
            _contexto.QuizzesDiarios.Update(quiz);
            await _contexto.SaveChangesAsync();
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
                            Pontos = questao.Nivel.Pontos,

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
                            Pontos = questao.Nivel.Pontos,

                            Acertou = quiz.UsuarioRespostas
                                .Where(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuizId == quiz.Id && resposta.QuestaoId == questao.Id)
                                .Select(resposta => resposta.Acertou)
                                .FirstOrDefault(),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new QuizDiarioResultadoAlternativa
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto,
                                Correta = alternativa.Correta
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
                            Pontos = questao.Nivel.Pontos,

                            Acertou = quiz.UsuarioRespostas
                                .Where(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.QuizId == quiz.Id && resposta.QuestaoId == questao.Id)
                                .Select(resposta => resposta.Acertou)
                                .FirstOrDefault(),

                            Alternativas = questao.Alternativas
                            .Select(alternativa => new QuizDiarioHistoricoAlternativa
                            {
                                Id = alternativa.Id,
                                Texto = alternativa.Texto,
                                Correta = alternativa.Correta
                            }).ToList(),
                    }).ToList()
                });
        }
    }
}
