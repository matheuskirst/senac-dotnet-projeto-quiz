using SenacQuizApp.Repositories;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // Determina se o nome já está sendo usado
        public async Task<bool> VerificarNome(string nome)
        {
            var usuario = await _usuarioRepository.ObterPorNome(nome);
            return usuario != null;
        }

        // Login
        public async Task<LoginResposta> RealizarLogin(LoginInput login)
        {
            Usuario? usuario = await _usuarioRepository.ObterPorNome(login.Username);

            if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(login.Senha, usuario.Senha))
            {
                return new LoginResposta(mensagemErro: MensagemErro.LoginInvalido);
            }

            UsuarioLogado? usuarioLogado = new()
            {
                Id = usuario.Id,
                Username = usuario.Username,
                Nickname = usuario.Nickname,
                DataDeNascimento = usuario.DataDeNascimento,
                DataDeCadastro = usuario.DataDeCadastro,
                Nivel = usuario.Nivel,
                PontuacaoTotal = usuario.PontuacaoTotal,
                TotalAcertos = usuario.TotalAcertos,
                TotalRespondidos = usuario.TotalRespondidos,
                AcertosConsecutivos = usuario.AcertosConsecutivos,
                MaxAcertosConsecutivos = usuario.MaxAcertosConsecutivos
            };

            Sessao.IniciarSessao(usuarioLogado);
            return new LoginResposta();
        }

        // Signup
        public async Task<LoginResposta> RealizarSignup(
            string username,
            string nickname,
            DateTime? dataDeNascimento,
            string senha
            )
        {
            bool usernameIndisponivel = await VerificarNome(username);

            if (usernameIndisponivel)
            {
                LoginResposta resultado = new LoginResposta(mensagemErro: MensagemErro.NomeIndisponivel);
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

                await _usuarioRepository.RegistrarUsuario(usuario);

                LoginInput login = new(Username: username, Senha: senha);

                LoginResposta resultado = await RealizarLogin(login);
                return resultado;
            }
        }

        public void RealizarLogout()
        {
            Sessao.EncerrarSessao();
        }
    }
}
