using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    // Objeto para exibir tentativas de quizzes diários (não concluídos)
    public record QuizDiarioTentativa {
        public int Id { get; set; }
        public DateOnly DataExibido { get; set; }
        public bool FoiConcluido { get; set; }
        public int? PontuacaoTotal { get; set; }
        public List<QuestaoExibicao> Questoes { get; set; } = null!;
    }
}
