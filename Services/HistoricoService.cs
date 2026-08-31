using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Services
{
    public class HistoricoService
    {
        public async Task<List<QuizResumo>> ObterResumoRecentes()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var diarios = contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new QuizResumo
                {
                    Id = diario.Id,
                    TipoId = QuizTipo.Diario,
                    Tipo = "Diário",
                    DataIniciado = diario.DataIniciado,
                    Finalizado = diario.Concluido,
                    DataFinalizado = diario.DataConcluido != null ? diario.DataConcluido.Value : null,
                    Tempo = diario.TempoDeConclusao,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            var rush = contexto.QuizzesRush
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(rush => new QuizResumo
                {
                    Id = rush.Id,
                    TipoId = QuizTipo.Rush,
                    Tipo = "Rush",
                    DataIniciado = rush.DataIniciado,
                    Finalizado = null,
                    DataFinalizado = rush.DataFinalizado,
                    Tempo = rush.Tempo,
                    PontuacaoTotal = rush.PontuacaoTotal
                });

            return await diarios
                .Concat(rush)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .Take(10)
                .ToListAsync();
        }
        
        public async Task<List<QuizResumo>> ObterTodos()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var diarios = contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new QuizResumo
                {
                    Id = diario.Id,
                    TipoId = QuizTipo.Diario,
                    Tipo = "Diário",
                    DataIniciado = diario.DataIniciado,
                    Finalizado = diario.Concluido,
                    DataFinalizado = diario.DataConcluido != null ? diario.DataConcluido.Value : null,
                    Tempo = diario.TempoDeConclusao,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            var rush = contexto.QuizzesRush
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new QuizResumo
                {
                    Id = diario.Id,
                    TipoId = QuizTipo.Rush,
                    Tipo = "Rush",
                    DataIniciado = diario.DataIniciado,
                    Finalizado = null,
                    DataFinalizado = diario.DataFinalizado,
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
                    Concluido = quiz.Concluido,
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
