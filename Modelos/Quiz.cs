using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Quiz
    {
        public int Id { get; set; }
        public int Usuario {  get; set; }
        public DateTime DataDaCriacao { get; set; }
        public int PontuacaoTotal { get; set; }

        
    }
}
