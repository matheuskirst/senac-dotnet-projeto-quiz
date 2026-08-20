using SenacQuizApp.Repositories;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos;
using SenacQuizApp.Data;

namespace SenacQuizApp.Services
{
    public class AutenticacaoService
    {
        private readonly QuizAppContexto _contexto;
        private readonly UsuarioRepository _usuarioRepository;

        public AutenticacaoService(QuizAppContexto contexto, UsuarioRepository usuarioRepository)
        {
            _contexto = contexto;
            _usuarioRepository = usuarioRepository;
        }

        // Determina se o nome já está sendo usado
        public async Task<bool> VerificarNome(string nome)
        {
            var usuario = await _usuarioRepository.ObterPorUsername(nome);
            return usuario != null;
        }

        // Login
        public async Task<LoginResponse> RealizarLogin(LoginRequest login)
        {
            Usuario? usuario = await _usuarioRepository.ObterPorUsername(login.Username);

            if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(login.Senha, usuario.Senha))
            {
                return new LoginResponse(IsSucesso: false, MensagemErro: Mensagem.LoginInvalidoErro);
            }

            UsuarioAtual.IniciarSessao(id: usuario.Id, username: usuario.Username);
            return new LoginResponse(IsSucesso: true);
        }

        // Signup
        public async Task<LoginResponse> RealizarSignup(
            string username,
            string nickname,
            DateTime? dataDeNascimento,
            string senha
            )
        {
            bool usernameIndisponivel = await VerificarNome(username);

            if (usernameIndisponivel)
            {
                LoginResponse resultado = new LoginResponse(IsSucesso: false, MensagemErro: Mensagem.NomeIndisponivelErro);
                return resultado;
            }
            else
            {
                string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha);

                var usuario = new Usuario
                {
                    Username = username,
                    Nickname = nickname,
                    DataDeNascimento = dataDeNascimento,
                    Senha = senhaHash
                };

                await _usuarioRepository.Adicionar(usuario);

                LoginRequest login = new(Username: username, Senha: senha);

                LoginResponse resultado = await RealizarLogin(login);
                return resultado;
            }
        }

        public void RealizarLogout()
        {
            UsuarioAtual.EncerrarSessao();
        }
    }
}
