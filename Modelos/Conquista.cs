using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Questoes;
using SenacQuizApp.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Conquista
    {
        public ConquistaId Id { get; set; }

        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public ConquistaTipo Tipo { get; set; }
        public int? Meta { get; set; }
        public int? TemaId { get; set; }
        public QuestaoTema Tema { get; set; } = null!;
        public bool Secreta { get; set; }
        public string IconePath { get; set; } = null!;

        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();
    }
}
