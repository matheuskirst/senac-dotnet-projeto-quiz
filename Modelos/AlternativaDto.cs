using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Entidades;

namespace SenacQuizApp.Modelos
{
    public class AlternativaDto
    {
        public int Id { get; set; }
        public string Texto { get; set; } = string.Empty;
        public Pergunta Pergunta { get; set; } = null!;
    }
}
