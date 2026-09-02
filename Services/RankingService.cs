using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Services
{
    public class RankingService
    {
        public async Task<List<UsuarioRank>> ObterUsuariosRank(string? nickname=null)
        {
            using var contexto = new QuizAppContexto();

            IQueryable<Usuario> query = contexto.Usuarios;

            if (nickname != null)
            {
                query = query.Where(ur => ur.Nickname.ToLower().StartsWith(nickname.ToLower()));
            }

            return await query
                .Select(usuario => new UsuarioRank
                {
                    Id = usuario.Id,
                    Nickname = usuario.Nickname,
                    PontuacaoTotal = usuario.Stats.PontuacaoTotal,
                    Nivel = usuario.Stats.Nivel.Nome,
                    TotalAcertos = usuario.Stats.TotalAcertos,
                    TotalRespondidos = usuario.Stats.TotalRespondidos,
                    MaxAcertosConsecutivos = usuario.Stats.MaxAcertosSeguidos
                })
                .OrderByDescending(rank => rank.PontuacaoTotal)
                .ToListAsync();
        }
    }
}
