using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioRushRecorde
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public int MaxStreak { get; set; }
        public TimeSpan Tempo { get; set; }

        public DateTimeOffset DataRecorde { get; set; }
    }
}
