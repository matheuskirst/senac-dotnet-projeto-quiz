using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Ranking
{
    public class UsuarioRankDiario : UsuarioRankGeral
    {
        public int PontosDiarios { get; set; }
        public int TotalAcertosDiarios { get; set; }
        public int MaxAcertosConsecutivos { get; set; }
    }
}
