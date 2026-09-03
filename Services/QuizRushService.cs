using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Usuarios;
using System.Data;
using static SenacQuizApp.Global.ModelosConstantes;

namespace SenacQuizApp.Services
{
    public class QuizRushService
    {
        public async Task<RushUltimoRecorde?> ObterUltimoRecorde()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            return await contexto.UsuarioRushRecordes
                .Where(r => r.UsuarioId == usuarioId)
                .OrderByDescending(r => r.DataRecorde)
                .Select(r => new RushUltimoRecorde
                {
                    Streak = r.MaxStreak,
                    Tempo = r.Tempo,
                    DataRecorde = r.DataRecorde
                })
                .FirstOrDefaultAsync();
        }

        public async Task<QuestaoExibicao?> ObterQuestaoAleatoria()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.Questoes
                .Select(questao => new QuestaoExibicao
                {
                    Id = questao.Id,
                    TemaId = questao.TemaId,
                    Tema = questao.Tema.Nome,
                    NivelId = questao.NivelId,
                    Nivel = questao.Nivel.Nome,
                    Tipo = questao.Tipo,
                    Enunciado = questao.Enunciado,
                    Respondida = false,
                    Pontos = questao.Nivel.Valor,
                    Alternativas = questao.Alternativas.Select(alternativa => new AlternativaExibicao
                    {
                        Id = alternativa.Id,
                        Texto = alternativa.Texto
                    })
                    .OrderBy(q => EF.Functions.Random())
                    .ToList()
                })
                .OrderBy(q => EF.Functions.Random())
                .FirstOrDefaultAsync();
        }

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

        public async Task<bool> FinalizarPartidaRush(DateTimeOffset dataIniciado, int streakFinal, int pontuacaoTotal)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            var usuarioStats = await contexto.UsuarioStats
                .FirstOrDefaultAsync(stats => stats.UsuarioId == usuarioId);

            UsuarioRushRecorde? recordeAtual = await contexto.UsuarioRushRecordes
                .FirstOrDefaultAsync(stats => stats.UsuarioId == usuarioId);

            if (usuarioStats == null) throw new Exception();

            if (pontuacaoTotal > 0)
            {
                usuarioStats.AdicionarPontos(pontuacaoTotal);
            }

            DateTimeOffset dataFinalizado = DateTimeOffset.UtcNow;
            TimeSpan tempo = dataFinalizado - dataIniciado;

            bool recordeBatido = false;
            int streakAtual = 0;

            if (recordeAtual == null)
            {
                recordeAtual = new UsuarioRushRecorde
                {
                    UsuarioId = usuarioId,
                    MaxStreak = streakFinal,
                    Tempo = tempo,
                    DataRecorde = DateTimeOffset.UtcNow
                };

                contexto.UsuarioRushRecordes.Add(recordeAtual);
                recordeBatido = true;
            }
            else if (streakFinal > recordeAtual.MaxStreak)
            {
                streakAtual = recordeAtual.MaxStreak;

                recordeAtual.MaxStreak = streakFinal;
                recordeAtual.Tempo = tempo;
                recordeAtual.DataRecorde = dataFinalizado;

                recordeBatido = true;
            }

            if (recordeBatido)
            {
                var historico = new RushHistorico
                {
                    UsuarioId = usuarioId,
                    RecordeAntigo = streakAtual,
                    RecordeNovo = streakFinal,
                    DataRecordeBatido = dataFinalizado
                };

                contexto.RushHistoricos.Add(historico);
            }

            await contexto.SaveChangesAsync();

            return recordeBatido;
        }
    }
}
