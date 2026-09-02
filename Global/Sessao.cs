namespace SenacQuizApp.Global
{
    public static class UsuarioAtual
    {
        public static int Id { get; private set; }
        public static string Username { get; private set; } = string.Empty;
        public static string Nickname { get; private set; } = string.Empty;

        public static void IniciarSessao(int id, string username, string nickname)
        {
            Id = id;
            Username = username;
            Nickname = nickname;
        }

        public static void EncerrarSessao()
        {
            Id = 0;
            Username = string.Empty;
            Nickname = string.Empty;
        }
    }
}
