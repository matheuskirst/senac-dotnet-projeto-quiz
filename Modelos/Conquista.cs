using SenacQuizApp.Enums;
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

        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();
    }
}
