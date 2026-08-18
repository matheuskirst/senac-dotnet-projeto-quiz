using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class PerguntasEncontradas
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public PerguntaTema Tema { get; set; }
        public PerguntaTipo Tipo { get; set; }
        public PerguntaNivel Nivel { get; set; }
        public List<AlternativaDto> Alternativas { get; set; } = new List<AlternativaDto>();
    }
}
