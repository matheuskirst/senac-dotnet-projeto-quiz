using SenacQuizApp.Repositories;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos;
using SenacQuizApp.Data;
using SenacQuizApp.Global;
using SenacQuizApp.Dtos.Usuario;

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
        public async Task<bool> VerificarUsername(string username)
        {
            var usuario = await _usuarioRepository.ObterPorUsername(username);
            return usuario != null;
        }

        // Login
        public async Task<AutenticacaoResponse> RealizarLogin(AutenticacaoRequest login)
        {
            Usuario? usuario = await _usuarioRepository.ObterPorUsername(login.Username);

            if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(login.Senha, usuario.Senha))
            {
                return new AutenticacaoResponse(IsSucesso: false, Erro: ErroAutenticacao.LoginInvalido);
            }

            UsuarioAtual.IniciarSessao(id: usuario.Id, username: usuario.Username);
            return new AutenticacaoResponse(IsSucesso: true);
        }

        // Signup
        public async Task<AutenticacaoResponse> RealizarSignup(
            string username,
            string nickname,
            DateTime? dataDeNascimento,
            string senha
            )
        {
            bool usernameIndisponivel = await VerificarUsername(username);

            if (usernameIndisponivel)
            {
                AutenticacaoResponse resultado = new AutenticacaoResponse(IsSucesso: false, Erro: ErroAutenticacao.NomeIndisponivel);
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
                    Senha = senhaHash,
                    Stats = new UsuarioStats
                    {
                        NivelId = UsuarioNivelId.Iniciante
                    }
                };


                _usuarioRepository.Adicionar(usuario);
                await _contexto.SaveChangesAsync();

                AutenticacaoRequest login = new(Username: username, Senha: senha);

                AutenticacaoResponse resultado = await RealizarLogin(login);
                return resultado;
            }
        }

        public void RealizarLogout()
        {
            UsuarioAtual.EncerrarSessao();
        }
    }
}
