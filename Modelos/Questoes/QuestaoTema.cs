using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Modelos.Questoes
{
    public class QuestaoTema
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public ICollection<Questao> Questoes { get; set; } = new List<Questao>();
    }
}
