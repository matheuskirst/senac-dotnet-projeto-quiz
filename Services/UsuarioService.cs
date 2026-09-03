using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Conquista;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Services
{
    public class UsuarioService
    {
        public async Task<UsuarioPerfil?> ObterPerfilPorId(int usuarioId)
        {
            using var contexto = new QuizAppContexto();

            int totalUsuarios = await contexto.Usuarios.CountAsync();
            if (totalUsuarios == 0) totalUsuarios = 1;

            return await contexto.Usuarios
                .AsNoTracking()
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => new UsuarioPerfil
                {
                    Id = usuario.Id,
                    Nickname = usuario.Nickname,
                    DataDeCadastro = usuario.DataDeCadastro,
                    NivelId = usuario.Stats.NivelId,
                    Nivel = usuario.Stats.Nivel.Nome,
                    PontuacaoTotal = usuario.Stats.PontuacaoTotal,
                    TotalAcertos = usuario.Stats.TotalAcertos,
                    TotalRespondidos = usuario.Stats.TotalRespondidos,
                    AtualAcertosSeguidos = usuario.Stats.AtualAcertosSeguidos,
                    MaxAcertosSeguidos = usuario.Stats.MaxAcertosSeguidos,

                    TemaMaisAcertado = usuario.TemaProgressos
                    .OrderByDescending(tp => tp.RespostasCorretas)
                    .Select(tp => new TemaDestaque
                    {
                        Nome = tp.Tema.Nome,
                        RespostasCorretas = tp.RespostasCorretas
                    })
                    .FirstOrDefault(),

                    Conquistas = contexto.Conquistas
                        .Select(c => new ConquistaDetalhes
                        {
                            Nome = c.Nome,
                            Descricao = c.Descricao,
                            Desbloqueada = c.UsuarioConquistas.Any(uc => uc.UsuarioId == usuarioId),

                            DataDesbloqueio = c.UsuarioConquistas
                            .Where(uc => uc.UsuarioId == usuarioId)
                            .Select(uc => (DateTimeOffset?)uc.DataDesbloqueio)
                            .FirstOrDefault(),

                            PorcentagemDesbloqueioGlobal = Math.Round((c.UsuarioConquistas.Count() * 100.0) / totalUsuarios, 2),
                            Secreta = c.Secreta,
                            Icone = c.IconePath
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
