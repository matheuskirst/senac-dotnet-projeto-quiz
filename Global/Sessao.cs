using SenacQuizApp.Dtos;
using System.ComponentModel.DataAnnotations;

namespace SenacQuizApp.Global
{
    public static class UsuarioAtual
    {
        public static int Id { get; private set; }
        public static string Username { get; private set; } = string.Empty;

        public static void IniciarSessao(int id, string username)
        {
            Id = id;
            Username = username;
        }

        public static void EncerrarSessao()
        {
            Id = 0;
            Username = string.Empty;
        }
    }
}
