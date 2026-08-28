using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizRush
{
    public class QuizRushEntrada
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTimeOffset DataIniciado { get; set; }
        public DateTimeOffset DataFinalizado { get; set; }
        public TimeSpan Tempo { get; set; }
        public int Streak { get; set; }
        public int PontuacaoTotal { get; set; }
    }
}
