using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Entidades
{
    public class UsuarioConquista
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int ConquistaId { get; set; }
        public Conquista Conquista { get; set; } = null!;
        public DateTime? DataDeAquisicao { get; set; } = DateTime.UtcNow;
    }
}
