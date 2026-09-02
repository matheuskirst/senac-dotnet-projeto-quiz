using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Objeto para exibir quizzes diários concluídos
    public class QuizDiarioCompleto {
        public int Id { get; set; }
        public DateOnly DataExibido { get; set; }
        public DateTimeOffset DataIniciado { get; set; }
        public DateTimeOffset? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int TotalQuestoes { get; set; }
        public int TotalAcertos { get; set; }
        public int PontuacaoTotal { get; set; }
        public List<QuestaoRespondida> Questoes { get; set; } = null!;
    }
}
