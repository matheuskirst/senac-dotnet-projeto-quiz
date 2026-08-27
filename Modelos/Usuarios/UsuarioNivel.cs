using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioNivel
    {
        public UsuarioNivelId Id { get; set; }

        public string Nome { get; set; } = null!;
        public int PontosMin { get; set; }
        public int? PontosMax { get; set; }
    }
}
