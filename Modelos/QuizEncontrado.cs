using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class QuizEncontrado
    {
        public int Id { get; set; }
        public bool Concluido { get; set; }
        public List<PerguntasEncontradas> Perguntas { get; set; } = new List<PerguntasEncontradas>();
    }
}
