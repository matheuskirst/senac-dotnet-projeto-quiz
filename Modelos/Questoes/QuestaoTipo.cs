using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Questoes
{
    public class QuestaoTipo
    {
        public QuestaoTipoId Id { get; set; }
        public string Nome { get; set; } = null!;
    }
}
