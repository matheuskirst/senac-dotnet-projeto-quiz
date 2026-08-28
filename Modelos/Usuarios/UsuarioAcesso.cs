using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioAcesso
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public DateOnly DataAcesso { get; set; }
    }
}
