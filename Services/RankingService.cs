using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Ranking;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Services
{
    public class RankingService
    {
        public async Task<List<UsuarioRankGeral>> ObterRankingGeral(string? nickname = null)
        {
            using var contexto = new QuizAppContexto();

            IQueryable<Usuario> query = contexto.Usuarios;

            if (nickname != null)
            {
                query = query.Where(ur => ur.Nickname.ToLower().StartsWith(nickname.ToLower()));
            }

            return await query
                .Select(usuario => new UsuarioRankGeral
                {
                    Id = usuario.Id,
                    Nickname = usuario.Nickname,
                    PontuacaoTotal = usuario.Stats.PontuacaoTotal,
                    Nivel = usuario.Stats.Nivel.Nome,
                    TotalAcertos = usuario.Stats.TotalAcertos,
                    TotalRespondidos = usuario.Stats.TotalRespondidos,
                    TemaMaisAcertado = usuario.TemaProgressos
                        .OrderByDescending(tp => tp.RespostasCorretas)
                        .Select(tp => new TemaDestaque
                        {
                            Nome = tp.Tema.Nome,
                            RespostasCorretas = tp.RespostasCorretas
                        })
                        .FirstOrDefault(),
                })
                .OrderByDescending(rank => rank.PontuacaoTotal)
                .ToListAsync();
        }

        public async Task<List<UsuarioRankDiario>> ObterRankingDiario(string? nickname = null)
        {
            using var contexto = new QuizAppContexto();

            IQueryable<UsuarioDiarioRecorde> query = contexto.UsuarioDiarioRecordes;

            if (nickname != null)
            {
                query = query.Where(dr => dr.Usuario.Nickname.ToLower().StartsWith(nickname.ToLower()));
            }

            return await query
                .OrderByDescending(dr => dr.PontosDiarios)
                .ThenByDescending(dr => dr.TotalAcertosDiarios)
                .ThenByDescending(dr => dr.MaxAcertosSeguidos)
                .Select(dr => new UsuarioRankDiario
                {
                    Id = dr.UsuarioId,
                    Nickname = dr.Usuario.Nickname,
                    TotalAcertosDiarios = dr.TotalAcertosDiarios,
                    MaxAcertosConsecutivos = dr.MaxAcertosSeguidos,
                })
         
                .ToListAsync();
        }

        public async Task<List<UsuarioRankRush>> ObterRankingRush(string? nickname = null)
        {
            using var contexto = new QuizAppContexto();

            IQueryable<UsuarioRushRecorde> query = contexto.UsuarioRushRecordes;

            if (nickname != null)
            {
                query = query.Where(rr => rr.Usuario.Nickname.ToLower().StartsWith(nickname.ToLower()));
            }

            return await query
                .OrderByDescending(rr => rr.MaxStreak)
                .ThenBy(rr => rr.Tempo)
                .Select(dr => new UsuarioRankRush
                {
                    Id = dr.UsuarioId,
                    Nickname = dr.Usuario.Nickname,
                    Recorde = dr.MaxStreak,
                    Tempo = dr.Tempo
                })
                .ToListAsync();
        }
    }
}
