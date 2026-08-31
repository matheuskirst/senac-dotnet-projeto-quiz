using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Alternativa sem resposta correta para exibição
    public class AlternativaAndamento()
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
    }
}
