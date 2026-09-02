using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Historico
{
    // Objeto para exibir partidas de quizzes rush
    public class QuizRushEntrada : QuizGenerico
    {
        public int Streak { get; set; }
    }
}
