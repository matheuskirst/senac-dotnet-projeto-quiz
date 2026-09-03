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
        public async Task<List<QuizDiarioHistorico>> ObterDiariosRecentes()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Select(diario => new QuizDiarioHistorico
                {
                    Id = diario.Id,
                    TipoId = QuizTipo.Diario,
                    Tipo = "Diário",
                    DataIniciado = diario.DataIniciado,
                    Concluido = diario.Concluido,
                    DataConcluido = diario.DataConcluido != null ? diario.DataConcluido.Value : null,
                    Tempo = diario.TempoDeConclusao,
                    PontuacaoTotal = diario.PontuacaoTotal
                })
                .OrderByDescending(quiz => quiz.DataIniciado)
                .Take(10)
                .ToListAsync();
        }
        
        public async Task<List<QuizDiarioHistorico>> ObterHistoricoDiario(DateTime? minDate = null, DateTime? maxDate = null, QuizDiarioStatus? status = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.QuizzesDiarios
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .FiltrarPorData(minDate, maxDate)
                .FiltrarPorStatus(status)
                .QuizDiarioHistorico()
                .ToListAsync();
        }
        
        public async Task<List<RushRecordeBatido>> ObterHistoricoRush(DateTime? minDate = null, DateTime? maxDate = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.RushHistoricos
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .OrderByDescending(quiz => quiz.DataRecordeBatido)
                .FiltrarPorData(minDate, maxDate)
                .QuizRushEntrada()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<RushRecordeBatido>> ObterTodos(DateTime? minDate = null, DateTime? maxDate = null)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.RushHistoricos
                .OrderByDescending(quiz => quiz.DataRecordeBatido)
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
                    TipoId = QuizTipo.Diario,
                    Tipo = "Diário",
                    DataExibido = quiz.DataExibido,
                    DataIniciado = quiz.DataIniciado,
                    Concluido = quiz.Concluido,
                    DataConcluido = quiz.DataConcluido,
                    Tempo = quiz.TempoDeConclusao,

                    TotalQuestoes = quiz.Questoes
                        .Count(),

                    TotalAcertos = quiz.UsuarioRespostas
                        .Count(resposta => resposta.UsuarioId == quiz.UsuarioId && resposta.Acertou),

                    PontuacaoTotal = quiz.PontuacaoTotal,
                });
        }

        public static IQueryable<RushRecordeBatido> QuizRushEntrada(this IQueryable<Modelos.RushHistorico> query)
        {
            return query
                .Select(quiz => new RushRecordeBatido
                {
                    TipoId = QuizTipo.Rush,
                    Tipo = "Rush",
                    RecordeAntigo = quiz.RecordeAntigo,
                    RecordeNovo = quiz.RecordeNovo,
                    DataRecordeBatido = quiz.DataRecordeBatido
                });
        }

        public static IQueryable<QuizDiario> FiltrarPorStatus(this IQueryable<QuizDiario> query, QuizDiarioStatus? status)
        {
            if (status == null || status == QuizDiarioStatus.Todos) return query;

            bool Concluido = status == QuizDiarioStatus.Concluido;

            return query.Where(quiz => quiz.Concluido == Concluido);
        }

        public static IQueryable<QuizDiario> FiltrarPorData(this IQueryable<QuizDiario> query, DateTime? minDate, DateTime? maxDate)
        {
            if (minDate == null || maxDate == null) return query;

            return query.Where(quiz => quiz.DataIniciado.DateTime >= minDate && quiz.DataIniciado.DateTime <= maxDate);
        }

        public static IQueryable<RushHistorico> FiltrarPorData(this IQueryable<RushHistorico> query, DateTime? minDate, DateTime? maxDate)
        {
            if (minDate == null || maxDate == null) return query;

            return query.Where(quiz => quiz.DataRecordeBatido.DateTime >= minDate && quiz.DataRecordeBatido.DateTime <= maxDate);
        }
    }
}
