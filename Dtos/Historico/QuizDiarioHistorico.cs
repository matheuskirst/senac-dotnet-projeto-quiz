using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Historico
{
    // Objeto para exibir histórico de quizzes diários (tentativas/concluído)
    public class QuizDiarioHistorico : QuizGenerico
    {
        public DateOnly DataExibido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int TotalQuestoes { get; set; }
        public int TotalAcertos { get; set; }
    }
}
