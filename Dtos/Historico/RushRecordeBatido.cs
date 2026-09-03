using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Historico
{
    // Objeto para exibir partidas de quizzes rush
    public class RushRecordeBatido
    {
        public QuizTipo TipoId { get; set; }
        public string Tipo { get; set; } = null!;
        public int RecordeAntigo { get; set; }
        public int RecordeNovo { get; set; }
        public DateTimeOffset DataRecordeBatido { get; set; }
    }
}
