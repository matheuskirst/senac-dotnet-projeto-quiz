using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizDiario.Resultado
{
    public class QuizDiarioResultado {
        public int Id { get; set; }
        public DateTimeOffset DataInicio { get; set; }
        public DateOnly DataExibido { get; set; }
        public DateTimeOffset? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int TotalQuestoes { get; set; }
        public int TotalAcertos { get; set; }
        public int PontuacaoTotal { get; set; }
        public List<QuizDiarioResultadoQuestao> Questoes { get; set; } = null!;
    }
}
