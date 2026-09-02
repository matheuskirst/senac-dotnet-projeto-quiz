using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Usuario
{
    public class TemaDestaque
    {
        public string Nome { get; set; } = string.Empty;
        public int RespostasCorretas { get; set; }
    }
}
