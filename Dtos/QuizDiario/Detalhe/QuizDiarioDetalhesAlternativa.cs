using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizDiario.Detalhe
{
    public class QuizDiarioDetalhesAlternativa()
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
    }
}
