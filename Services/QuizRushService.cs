using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Historico;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Usuarios;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Services
{
    public class QuizRushService
    {
        public async Task<bool?> VerificarRespostaAlternativa(int alternativaId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.Alternativas
                .Where(alternativa => alternativa.Id == alternativaId)
                .Select(alternativa => alternativa.EhCorreta)
                .FirstOrDefaultAsync();
        }

        public async Task<bool?> VerificarRespostaVerdadeiroFalso(int questaoId, bool verdadeiroFalso)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.Questoes
                .Where(questao => questao.Id == questaoId)
                .Select(questao => questao.VerdadeiroFalso == verdadeiroFalso)
                .FirstOrDefaultAsync();
        }

        public async Task<QuizRushEntrada?> ObterResultadoPorId(int quizId)
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
                    MotivoEncerrado = quiz.MotivoEncerrado,
                    Streak = quiz.Streak,
                    PontuacaoTotal = quiz.PontuacaoTotal
                })
                .FirstOrDefaultAsync();
        }

        public async Task<int?> SalvarQuizRush(RushMotivoEncerrado motivo, DateTimeOffset dataIniciado, int streak, int pontuacaoTotal)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            UsuarioStats? usuarioStats = await contexto.Usuarios
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => usuario.Stats)
                .FirstOrDefaultAsync();

            if (usuarioStats == null) throw new Exception();

            DateTimeOffset dataConcluido = DateTimeOffset.UtcNow;

            TimeSpan tempo = dataConcluido - dataIniciado;

            var quiz = new QuizRush
            {
                UsuarioId = usuarioId,
                DataIniciado = dataIniciado,
                DataConcluido = dataConcluido,
                MotivoEncerrado = motivo,
                Tempo = tempo,
                Streak = streak,
                PontuacaoTotal = pontuacaoTotal
            };

            contexto.QuizzesRush.Add(quiz);
            usuarioStats.AdicionarPontos(pontuacaoTotal);
            usuarioStats.AtualizarAcertos(streak);
            if (motivo == RushMotivoEncerrado.RespostaErrada)
            {
                usuarioStats.LimparAcertosSeguidos();
            }
            await contexto.SaveChangesAsync();

            return await contexto.QuizzesRush
                .Where(r => r.UsuarioId == usuarioId && r.DataIniciado == dataIniciado)
                .Select(r => r.Id)
                .FirstOrDefaultAsync();
        }
    }
}
