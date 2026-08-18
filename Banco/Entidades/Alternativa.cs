using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Banco.Entidades
{
    public class Alternativa
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool EhCorreta { get; set; }
        public int PerguntaId { get; set; }
        public Pergunta Pergunta { get; set; }
    }
}
