using SenacQuizApp.Enums;

namespace SenacQuizApp.Global
{
    public static class UsuarioAtual
    {
        public static int Id { get; private set; }
        public static UsuarioTipoId? Tipo { get; private set; }
        public static string Username { get; private set; } = string.Empty;
        public static string Nickname { get; private set; } = string.Empty;

        public static void IniciarSessao(int id, UsuarioTipoId tipo, string username, string nickname)
        {
            Id = id;
            Tipo = tipo;
            Username = username;
            Nickname = nickname;
        }

        public static void EncerrarSessao()
        {
            Id = 0;
            Tipo = null;
            Username = string.Empty;
            Nickname = string.Empty;
        }
    }
}
