using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Entidades
{
    public class QuizTentativa
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public DateTime? DataInicio { get; set; } = DateTime.UtcNow;
        public DateTime? DataFim { get; set; }
        public int PontuacaoFinal { get; set; }

        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();
    }
}
