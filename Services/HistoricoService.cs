using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.QuizDiario.Historico;
using SenacQuizApp.Dtos.QuizRush;
using SenacQuizApp.Modelos;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Services
{
    public class HistoricoService
    {
        public async Task<List<ResumoQuiz>> ObterResumoRecentes()
        {
            using var contexto = new QuizAppContexto();

            var diarios = contexto.QuizzesDiarios
                .Select(diario => new ResumoQuiz
                {
                    Id = diario.Id,
                    Tipo = "Diário",
                    DataIniciado = diario.DataIniciado,
                    Finalizado = diario.Concluido ? "Sim" : "Não",
                    DataFinalizado = diario.DataConcluido,
                    Tempo = diario.TempoDeConclusao,
                    PontuacaoTotal = diario.PontuacaoTotal
                });

            var rush = contexto.QuizzesRush
                .Select(diario => new ResumoQuiz
                {
                    Id = diario.Id,
                    Tipo = "Rush",
                    DataIniciado = diario.DataIniciado,
                    Finalizado = "Sim",
                    DataFinalizado = diario.DataFinalizado,
                    Tempo = diario.Tempo,
                    PontuacaoTotal = diario.PontuacaoTotal
                }); ;;

            return await diarios
                .Concat(rush)
                .OrderByDescending(quiz => quiz.DataIniciado)
                .ToListAsync();
                
        }

        public async Task<List<QuizDiarioHistorico>> ObterHistoricoDiario()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuizzesDiarios
                .QuizDiarioHistorico()
                .ToListAsync();
        }

        public async Task<List<QuizRushEntrada>> ObterEntradaRush()
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
