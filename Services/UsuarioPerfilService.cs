using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SenacQuizApp.Services
{
    public class UsuarioPerfilService
    {
        private readonly QuizAppContexto _contexto;

        public UsuarioPerfilService(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<UsuarioPerfilDto?> ObterPerfilPorId(int usuarioId)
        {
            return await _contexto.Usuarios
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
                    AtualAcertosConsecutivos = usuario.Stats.AtualAcertosConsecutivos,
                    MaxAcertosConsecutivos = usuario.Stats.MaxAcertosConsecutivos
                })
                .FirstOrDefaultAsync();
        }
    }
}
