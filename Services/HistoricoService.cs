using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    Concluido = diario.Concluido,
                    DataConcluido = diario.DataConcluido != null ? diario.DataConcluido.Value : null,
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
                    Concluido = null,
                    DataConcluido = rush.DataConcluido,
                    Tempo = rush.Tempo,
                    PontuacaoTotal = rush.PontuacaoTotal
                });

            return await diarios
                .Concat(rush)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .Take(10)
                .ToListAsync();
        }
        
        public async Task<List<QuizResumo>> ObterTodos(DateTime? minDate = null, DateTime? maxDate = null)
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
                    Concluido = diario.Concluido,
                    DataConcluido = diario.DataConcluido != null ? diario.DataConcluido.Value : null,
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
                    Concluido = null,
                    DataConcluido = diario.DataConcluido,
                    Tempo = diario.Tempo,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            return await diarios
                .Concat(rush)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .FiltrarPorData(minDate, maxDate)
                .ToListAsync();
        }

        public async Task<List<QuizDiarioHistorico>> ObterHistoricosDiario(QuizStatus? status = null, DateTime? minDate = null, DateTime? maxDate = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .FiltrarPorStatus(status)
                .FiltrarPorData(minDate, maxDate)
                .QuizDiarioHistorico()
                .ToListAsync();
        }

        public async Task<List<QuizRushEntrada>> ObterEntradasRush(DateTime? minDate = null, DateTime? maxDate = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.QuizzesRush
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .FiltrarPorData(minDate, maxDate)
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
                    DataConcluido = quiz.DataConcluido,
                    Tempo = quiz.Tempo,
                    Streak = quiz.Streak,
                    PontuacaoTotal = quiz.PontuacaoTotal,
                });
        }

        public static IQueryable<QuizDiario> FiltrarPorStatus(this IQueryable<QuizDiario> query, QuizStatus? status)
        {
            if (status == null || status == QuizStatus.Todos) return query;

            bool Concluido = status == QuizStatus.Concluido;

            return query.Where(quiz => quiz.Concluido == Concluido);
        }

        public static IQueryable<QuizResumo> FiltrarPorData(this IQueryable<QuizResumo> query, DateTime? minDate, DateTime? maxDate)
        {
            if (minDate == null || maxDate == null) return query;

            return query.Where(quiz => quiz.DataIniciado >= minDate && quiz.DataIniciado <= maxDate);
        }

        public static IQueryable<QuizDiario> FiltrarPorData(this IQueryable<QuizDiario> query, DateTime? minDate, DateTime? maxDate)
        {
            if (minDate == null || maxDate == null) return query;

            return query.Where(quiz => quiz.DataIniciado >= minDate && quiz.DataIniciado <= maxDate);
        }

        public static IQueryable<QuizRush> FiltrarPorData(this IQueryable<QuizRush> query, DateTime? minDate, DateTime? maxDate)
        {
            if (minDate == null || maxDate == null) return query;

            return query.Where(quiz => quiz.DataIniciado >= minDate && quiz.DataIniciado <= maxDate);
        }
    }
}
