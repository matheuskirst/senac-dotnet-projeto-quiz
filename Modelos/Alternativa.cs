using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Alternativa
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
        public bool IsCorreta { get; set; }
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; } = null!;
    }
}
