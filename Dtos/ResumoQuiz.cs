using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public class ResumoQuiz
    {
        public int Id { get; set; }
        public QuizTipoId TipoId { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTime DataIniciado { get; set; }
        public string Finalizado { get; set; } = null!;
        public DateTime? DataFinalizado { get; set; }
        public TimeSpan? Tempo { get; set; }
        public int PontuacaoTotal { get; set; }
    }
}
