using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Quiz
    {
        public int Id { get; set; }
        public int? QuantidadePerguntas { get; set; } = 10;
        public DateTime? DataDeCriacao { get; set; }

        public ICollection<Pergunta> Perguntas { get; set; } = new List<Pergunta>();
        public ICollection<QuizTentativa> QuizTentativas { get; set; } = new List<QuizTentativa>();
    }
}
