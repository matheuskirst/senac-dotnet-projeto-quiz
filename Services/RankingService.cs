using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services
{
    public class RankingService
    {
        public async Task<List<UsuarioRankDto>> ObterUsuariosRank()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.Usuarios
                .Select(usuario => new UsuarioRankDto
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
