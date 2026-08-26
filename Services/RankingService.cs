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
        private readonly QuizAppContexto _contexto;
        public RankingService(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<UsuarioRankDto>> ObterUsuariosRank()
        {
            return await _contexto.Usuarios
                .Select(usuario => new UsuarioRankDto
                {
                    Id = usuario.Id,
                    Nickname = usuario.Nickname,
                    PontuacaoTotal = usuario.Stats.PontuacaoTotal,
                    Nivel = usuario.Stats.Nivel.Nome,
                    TotalAcertos = usuario.Stats.TotalAcertos,
                    TotalRespondidos = usuario.Stats.TotalRespondidos,
                    MaxAcertosConsecutivos = usuario.Stats.MaxAcertosConsecutivos
                })
                .OrderByDescending(rank => rank.PontuacaoTotal)
                .ToListAsync();
        }
    }
}
