using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Ranking
{
    public class UsuarioRankRush : UsuarioRankGeral
    {
        public int Recorde { get; set; }
        public TimeSpan Tempo { get; set; }
    }
}
