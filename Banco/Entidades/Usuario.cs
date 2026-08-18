using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Banco.Entidades
{
    public class NivelUsuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosMin { get; set; }
        public int PontosMax { get; set; }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public string Senha { get; set; }
        public DateTime? DataDeCadastro { get; set; } = DateTime.UtcNow;
        public int NivelUsuarioId { get; set; } = 1;
        public NivelUsuario Nivel { get; set; }
        public int PontuacaoTotal { get; set; } = 0;
        public int TotalAcertos { get; set; } = 0;
        public int TotalRespondidos { get; set; } = 0;
        public int AcertosConsecutivos { get; set; } = 0;
        public int MaxAcertosConsecutivos { get; set; } = 0;

        public ICollection<QuizTentativa> QuizTentativas { get; set; } = new List<QuizTentativa>();
        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();
    }
}
