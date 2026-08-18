using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Entidades
{
    public class Quiz
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataIniciado { get; set; } = DateTime.UtcNow;
        public bool Concluido { get; set; }
        public DateTime DataConcluido { get; set; }
        public int? PontuacaoFinal { get; set; }

        public ICollection<QuizPergunta> QuizPerguntas { get; set; } = new List<QuizPergunta>();
    }
}
