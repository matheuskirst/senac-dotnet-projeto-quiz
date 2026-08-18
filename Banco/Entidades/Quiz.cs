using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Banco.Entidades
{
    public class Quiz
    {
        public int Id { get; set; }
        public int QuantidadePerguntas { get; set; } = 10;
        public DateTime? DataDeCriacao { get; set; } = DateTime.UtcNow;
        public DateTime? DataExibicao { get; set; } = DateTime.UtcNow;

        public ICollection<QuizPergunta> QuizPerguntas { get; set; } = new List<QuizPergunta>();
        public ICollection<QuizTentativa> QuizTentativas { get; set; } = new List<QuizTentativa>();
    }
}
