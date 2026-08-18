using SenacQuizApp.Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class PerguntaDto
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public TipoPergunta Tipo { get; set; }
        public NivelPergunta Nivel { get; set; }
        public TemaPergunta Tema { get; set; }
        public List<AlternativaDto> Alternativas { get; set; }
    }
}
