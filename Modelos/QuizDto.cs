using SenacQuizApp.Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class QuizDto
    {
        public int Id { get; set; }
        public int? QuantidadePerguntas { get; set; }
        public List<PerguntaDto> Perguntas { get; set; }
    }
}
