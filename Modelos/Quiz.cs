using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public int? QuantidadePerguntas { get; set; } = 10;
        public DateTime? DataDeCriacao { get; set; }

        public ICollection<QuizPerguntas> QuizPerguntas { get; set; } = new List<QuizPerguntas>();
    }
}
