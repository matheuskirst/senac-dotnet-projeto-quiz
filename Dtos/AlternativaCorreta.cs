using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Objeto para exibir alternativas corretas de questões em um quiz diário concluído
    public class AlternativaCorreta
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
        public bool Correta { get; set; }
    }
}
