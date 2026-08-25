using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Quiz
{
    public record QuizDto {
        public int Id { get; set; }
        public DateOnly DataExibido { get; set; }
        public bool FoiConcluido { get; set; }
        public int? PontuacaoTotal { get; set; }
        public List<QuestaoDto> Questoes { get; set; } = null!;
    }
}
