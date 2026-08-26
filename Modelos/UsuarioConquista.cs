using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Modelos
{
    public class UsuarioConquista
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public ConquistaId ConquistaId { get; set; }
        public Conquista Conquista { get; set; } = null!;

        public DateTime? DataDeAquisicao { get; set; } = DateTime.UtcNow;
    }
}
