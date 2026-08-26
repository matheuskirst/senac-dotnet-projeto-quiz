using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Services
{
    public class AutenticacaoService
    {
        private readonly QuizAppContexto _contexto;

        public AutenticacaoService(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        // Determina se o nome já está sendo usado
        public async Task<bool> VerificarUsername(string username)
        {
            var usuario = await _contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Username == username);
            return usuario != null;
        }

        // Login
        public async Task<bool> RealizarLogin(string username, string senha)
        {
            Usuario? usuario = await _contexto.Usuarios
                                .FirstOrDefaultAsync(u => u.Username == username);

            if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(senha, usuario.Senha))
            {
                throw new LoginException("O Nome ou a Senha são inválidos!");
            }

            UsuarioAtual.IniciarSessao(id: usuario.Id, username: usuario.Username);
            return true;
        }

        // Signup
        public async Task<bool> RealizarSignup(
            string username,
            string nickname,
            DateOnly? dataDeNascimento,
            string senha
            )
        {
            bool usernameIndisponivel = await VerificarUsername(username);

            if (usernameIndisponivel)
            {
                throw new UsernameInvalidoException();
            }
            else
            {
                string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha);

                var usuario = new Usuario
                {
                    Username = username,
                    Nickname = nickname,
                    DataDeNascimento = dataDeNascimento,
                    Senha = senhaHash,
                    Stats = new UsuarioStats
                    {
                        NivelId = UsuarioNivelId.Iniciante
                    }
                };


                _contexto.Usuarios.Add(usuario);
                await _contexto.SaveChangesAsync();

                bool loginSucesso = await RealizarLogin(username, senha);
                if (loginSucesso)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void RealizarLogout()
        {
            UsuarioAtual.EncerrarSessao();
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
    public class UsernameInvalidoException : Exception
    {
        public UsernameInvalidoException() { }

        public UsernameInvalidoException(string message) : base(message) { }
    }

    public class LoginException : Exception
    {
        public LoginException() { }

        public LoginException(string message) : base(message) { }
    }
}
