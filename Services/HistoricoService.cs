using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizRush;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Services
{
    public class HistoricoService
    {
        public async Task<List<ResumoQuiz>> ObterResumoRecentes()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var diarios = contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new ResumoQuiz
                {
                    Id = diario.Id,
                    TipoId = QuizTipoId.Diario,
                    Tipo = "Diário",
                    DataIniciado = diario.DataIniciado.DateTime,
                    Finalizado = diario.Concluido ? "Sim" : "Não",
                    DataFinalizado = diario.DataConcluido != null ? diario.DataConcluido.Value.DateTime : null,
                    Tempo = diario.TempoDeConclusao,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            var rush = contexto.QuizzesRush
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new ResumoQuiz
                {
                    Id = diario.Id,
                    TipoId = QuizTipoId.Rush,
                    Tipo = "Rush",
                    DataIniciado = diario.DataIniciado.DateTime,
                    Finalizado = "Sim",
                    DataFinalizado = diario.DataFinalizado.DateTime,
                    Tempo = diario.Tempo,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            return await diarios
                .Concat(rush)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .Take(10)
                .ToListAsync();
        }        
        
        public async Task<List<ResumoQuiz>> ObterTodos()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var diarios = contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new ResumoQuiz
                {
                    Id = diario.Id,
                    TipoId = QuizTipoId.Diario,
                    Tipo = "Diário",
                    DataIniciado = diario.DataIniciado.DateTime,
                    Finalizado = diario.Concluido ? "Sim" : "Não",
                    DataFinalizado = diario.DataConcluido != null ? diario.DataConcluido.Value.DateTime : null,
                    Tempo = diario.TempoDeConclusao,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            var rush = contexto.QuizzesRush
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new ResumoQuiz
                {
                    Id = diario.Id,
                    TipoId = QuizTipoId.Rush,
                    Tipo = "Rush",
                    DataIniciado = diario.DataIniciado.DateTime,
                    Finalizado = "Sim",
                    DataFinalizado = diario.DataFinalizado.DateTime,
                    Tempo = diario.Tempo,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            return await diarios
                .Concat(rush)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .ToListAsync();
        }

        public async Task<List<QuizDiarioHistorico>> ObterHistoricosDiario()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .QuizDiarioHistorico()
                .ToListAsync();
        }

        public async Task<List<QuizRushEntrada>> ObterEntradasRush()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesRush
                .QuizRushEntrada()
                .ToListAsync();
        }
    }

    public static class HistoricoQueryExtensoes
    {   
        public static IQueryable<QuizDiarioHistorico> QuizDiarioHistorico(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizDiarioHistorico
                {
                    Id = quiz.Id,
                    Tipo = "Diário",
                    DataExibido = quiz.DataExibido,
                    DataIniciado = quiz.DataIniciado,
                    Concluido = quiz.Concluido ? "Sim" : "Não",
                    DataConcluido = quiz.DataConcluido,
                    TempoDeConclusao = quiz.TempoDeConclusao,

                    TotalQuestoes = quiz.Questoes
                        .Count(),

                    TotalAcertos = quiz.UsuarioRespostas
                        .Count(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.Acertou),

                    PontuacaoTotal = quiz.PontuacaoTotal,
                });
        }

        public static IQueryable<QuizRushEntrada> QuizRushEntrada(this IQueryable<QuizRush> query)
        {
            return query
                .Select(quiz => new QuizRushEntrada
                {
                    Id = quiz.Id,
                    Tipo = "Rush",
                    DataIniciado = quiz.DataIniciado,
                    DataFinalizado = quiz.DataFinalizado,
                    Tempo = quiz.Tempo,
                    Streak = quiz.Streak,
                    PontuacaoTotal = quiz.PontuacaoTotal,
                });
        }
    }
}
