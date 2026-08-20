using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class QuizPerguntas
    {
        public int Id {  get; set; }

        public int QuizId { get; set; }

        public Quiz Quiz { get; set; } = null!;

        public int PerguntaId { get; set; }

        public Pergunta Pergunta { get; set; } = null!;



    }
}
