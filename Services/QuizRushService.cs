using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;

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

        public async Task<int?> SalvarQuizRush(DateTimeOffset dataIniciado, int streak, int pontuacaoTotal)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            DateTimeOffset dataConcluido = DateTimeOffset.UtcNow;

            TimeSpan tempo = dataConcluido - dataIniciado;

            var quiz = new QuizRush
            {
                UsuarioId = usuarioId,
                DataIniciado = dataIniciado,
                DataConcluido = dataConcluido,
                Tempo = tempo,
                Streak = streak,
                PontuacaoTotal = pontuacaoTotal
            };

            contexto.QuizzesRush.Add(quiz);
            await contexto.SaveChangesAsync();

            return await contexto.QuizzesRush
                .Where(r => r.UsuarioId == usuarioId && quiz.DataConcluido == dataConcluido)
                .Select(r => r.Id)
                .FirstOrDefaultAsync();
        }
    }
}
