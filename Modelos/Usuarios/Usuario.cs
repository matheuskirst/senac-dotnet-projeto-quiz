using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class Usuario
    {
        public Usuario (string username, string senha, string? nickname = null)
        {
            Username = username;
            Senha = senha;
            Nickname = string.IsNullOrWhiteSpace(nickname) ? username.ToLower() : nickname;
        }

        public Usuario() { }

        public int Id { get; set; }

        public string Username { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public DateOnly? DataDeNascimento { get; set; }
        public string Senha { get; set; } = null!;
        public DateTime? DataDeCadastro { get; set; } = DateTime.UtcNow;

        public UsuarioStats Stats { get; set; } = null!;

        public ICollection<UsuarioResposta> Respostas { get; set; } = new List<UsuarioResposta>();
        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();
    }
}
