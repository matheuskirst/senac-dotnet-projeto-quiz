using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Entidades
{
    public class QuizPergunta
    {
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } = null!;
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; } = null!;
    }
}
