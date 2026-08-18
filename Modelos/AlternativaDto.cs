using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Banco.Entidades;

namespace SenacQuizApp.Modelos
{
    public class AlternativaDto
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public Pergunta Pergunta { get; set; }
    }
}
