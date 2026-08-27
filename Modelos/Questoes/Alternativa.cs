using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Questoes
{
    public class Alternativa
    {
        public int Id { get; set; }

        public int QuestaoId { get; set; }
        public Questao Questao { get; set; } = null!;

        public string Texto { get; set; } = null!;
        public bool Correta { get; set; }
    }
}
