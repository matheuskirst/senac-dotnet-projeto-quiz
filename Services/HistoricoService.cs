using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Historico;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SenacQuizApp.Services
{
    public class HistoricoService
    {
        public async Task<List<QuizGenerico>> ObterResumoRecentes()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var diarios = contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new QuizGenerico
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
                .Select(rush => new QuizGenerico
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
        
        public async Task<IEnumerable<QuizGenerico>> ObterTodos(QuizTipo tipo, DateTime? minDate = null, DateTime? maxDate = null, QuizStatus? status = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var diarios = contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new QuizGenerico
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
                .Select(diario => new QuizGenerico
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

            switch (tipo)
            {
                case QuizTipo.Diario:
                    return await contexto.QuizzesDiarios
                        .OrderByDescending(quiz => quiz.DataIniciado)
                        .FiltrarPorData(minDate, maxDate)
                        .FiltrarPorStatus(status)
                        .QuizDiarioHistorico()
                        .ToListAsync();
                case QuizTipo.Rush:
                    return await contexto.QuizzesRush
                        .OrderByDescending(quiz => quiz.DataIniciado)
                        .FiltrarPorData(minDate, maxDate)
                        .QuizRushEntrada()
                        .ToListAsync();
                default:
                    return await diarios
                        .Concat(rush)
                        .OrderByDescending(quiz => quiz.DataIniciado)
                        .FiltrarPorData(minDate, maxDate)
                        .FiltrarPorStatus(status)
                        .ToListAsync();
            }
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

        public static IQueryable<QuizGenerico> FiltrarPorStatus(this IQueryable<QuizGenerico> query, QuizStatus? status)
        {
            if (status == null || status == QuizStatus.Todos) return query;

            bool Concluido = status == QuizStatus.Concluido;

            return query.Where(quiz => quiz.Concluido == Concluido);
        }

        public static IQueryable<QuizDiario> FiltrarPorStatus(this IQueryable<QuizDiario> query, QuizStatus? status)
        {
            if (status == null || status == QuizStatus.Todos) return query;

            bool Concluido = status == QuizStatus.Concluido;

            return query.Where(quiz => quiz.Concluido == Concluido);
        }

        public static IQueryable<QuizGenerico> FiltrarPorData(this IQueryable<QuizGenerico> query, DateTime? minDate, DateTime? maxDate)
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
