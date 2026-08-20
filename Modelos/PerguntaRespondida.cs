using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class PerguntaRespondida
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } = null!;
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; } = null!;
        public bool Acertou { get; set; }
        public int Bonus { get; set; } = 0;
        public int PontuacaoFinal { get; set; } = 0;
        public DateTime? DataDeResposta { get; set; } = DateTime.UtcNow;
    }
}
