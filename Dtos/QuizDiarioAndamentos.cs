using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Objeto para quizzes diários em andamento (não concluídos)
    public record QuizDiarioAndamentos {
        public int Id { get; set; }
        public DateOnly DataExibido { get; set; }
        public bool FoiConcluido { get; set; }
        public int? PontuacaoTotal { get; set; }
        public List<QuestaoAndamento> Questoes { get; set; } = null!;
    }
}
