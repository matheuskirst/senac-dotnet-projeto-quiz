using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Services
{
    public class UsuarioService
    {
        public async Task<UsuarioPerfilDto?> ObterPerfilPorId(int usuarioId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.Usuarios
                .AsNoTracking()
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => new UsuarioPerfilDto
                {
                    Id = usuario.Id,
                    Nickname = usuario.Nickname,
                    DataDeCadastro = usuario.DataDeCadastro,
                    NivelId = usuario.Stats.NivelId,
                    Nivel = usuario.Stats.Nivel.Nome,
                    PontuacaoTotal = usuario.Stats.PontuacaoTotal,
                    TotalAcertos = usuario.Stats.TotalAcertos,
                    TotalRespondidos = usuario.Stats.TotalRespondidos,
                    AtualAcertosSeguidos = usuario.Stats.MaxAcertosSeguidos,
                    MaxAcertosSeguidos = usuario.Stats.AtualAcertosSeguidos,
                    Conquistas = usuario.Conquistas.Select(uc => new ConquistaDto
                    {
                        Nome = uc.Conquista.Nome,
                        Descricao = uc.Conquista.Descricao,
                        DataAquisicao = uc.DataDeAquisicao
                    }).ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
