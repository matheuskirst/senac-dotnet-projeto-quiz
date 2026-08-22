using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public DateTime? DataDeNascimento { get; set; }
        public string Senha { get; set; } = null!;
        public DateTime? DataDeCadastro { get; set; } = DateTime.UtcNow;

        public ICollection<UsuarioStatus> UsuarioStatus { get; set; } = new List<UsuarioStatus>();
        public ICollection<UsuarioResposta> UsuarioRespostas { get; set; } = new List<UsuarioResposta>();
        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();
    }
}
