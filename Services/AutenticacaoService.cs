using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Services
{
    public class AutenticacaoService
    {
        private readonly ConquistaService _conquistaService;

        public AutenticacaoService(ConquistaService conquistaService)
        {
            _conquistaService = conquistaService;
        }

        // Determina se o nome já está sendo usado
        public async Task<bool> VerificarUsername(string username)
        {
            using var contexto = new QuizAppContexto();

            var usuario = await contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Username == username);
            return usuario != null;
        }

        // Login
        public async Task<bool> RealizarLogin(string username, string senha)
        {
            using var contexto = new QuizAppContexto();

            Usuario? usuario = await contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Username == username);

            if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(senha, usuario.Senha))
            {
                throw new LoginException("O Nome ou a Senha são inválidos!");
            }

            var hoje = DateOnly.FromDateTime(DateTime.UtcNow);

            bool acessouHoje = await contexto.Acessos
                .AnyAsync(a => a.UsuarioId == usuario.Id && a.DataAcesso == hoje);

            if (!acessouHoje)
            {
                var acesso = new UsuarioAcesso
                {
                    UsuarioId = usuario.Id,
                    DataAcesso = hoje
                };

                contexto.Acessos.Add(acesso);
            }

            await contexto.SaveChangesAsync();

            await _conquistaService.ChecarLoginConquistas();

            UsuarioAtual.IniciarSessao(id: usuario.Id, username: usuario.Username, nickname: usuario.Nickname);
            return true;
        }

        // Signup
        public async Task<bool> RealizarSignup(
            string username,
            string nickname,
            DateOnly dataDeNascimento,
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

                using var contexto = new QuizAppContexto();

                contexto.Usuarios.Add(usuario);
                await contexto.SaveChangesAsync();

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
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;
            Usuario? usuario = await contexto.Usuarios
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
