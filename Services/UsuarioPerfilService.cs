using Microsoft.EntityFrameworkCore;
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
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => new UsuarioPerfilDto
                {
                    Id = usuario.Id,
                    Username = usuario.Username,
                    Nickname = usuario.Nickname,
                    DataDeCadastro = usuario.DataDeCadastro,
                    NivelId = usuario.Stats.NivelId,
                    Nivel = usuario.Stats.Nivel.Nome,
                    TotalAcertos = usuario.Stats.TotalAcertos,
                    TotalRespondidos = usuario.Stats.TotalRespondidos,
                    AtualAcertosConsecutivos = usuario.Stats.AtualAcertosConsecutivos,
                    MaxAcertosConsecutivos = usuario.Stats.MaxAcertosConsecutivos
                })
                .FirstOrDefaultAsync();
        }

        public async Task AtualizarSenha(string senha, string novaSenha)
        {
            int usuarioId = UsuarioAtual.Id;
            Usuario? usuario = await _contexto.Usuarios
                                .FirstOrDefaultAsync(u => u.Id == usuarioId);

            if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(senha, usuario.Senha))
            {
                return;
            }
        }
    }
}
