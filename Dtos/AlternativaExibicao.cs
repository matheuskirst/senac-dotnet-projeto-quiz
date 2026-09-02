using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Objeto para exibir alternativas em uma tentativa de quiz
    public class AlternativaExibicao
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
    }
}
