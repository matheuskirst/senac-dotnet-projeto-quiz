using SenacQuizApp.Dtos;

namespace SenacQuizApp
{
    public static class Sessao
    {
        public static UsuarioLogado? UsuarioAtual { get; private set; }

        public static void IniciarSessao(UsuarioLogado usuario)
        {
            UsuarioAtual = usuario;
        }

        public static void EncerrarSessao()
        {
            UsuarioAtual = null;
        }
    }
}
