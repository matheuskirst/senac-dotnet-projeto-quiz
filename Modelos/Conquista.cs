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
        public int ConquistaId { get; set; }

        [StringLength(30)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();
    }
}
