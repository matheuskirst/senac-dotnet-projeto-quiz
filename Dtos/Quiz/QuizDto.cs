using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Quiz
{
    public record QuizDto(
        int QuizId,
        DateOnly DataExibido,
        bool FoiConcluido,
        int? PontuacaoTotal,
        List<QuestaoDto> Questoes
        );
}
