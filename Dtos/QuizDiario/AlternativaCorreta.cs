using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizDiario
{
    // Alternativa correta para exibição do quiz diário concluído
    public class AlternativaCorreta
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
        public bool Correta { get; set; }
    }
}
