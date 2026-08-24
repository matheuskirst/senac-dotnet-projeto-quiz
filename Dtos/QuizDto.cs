using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public record QuizDto(
        int Id,
        bool IsConcluido,
        TimeSpan? TempoDeConclusao,
        int PontuacaoTotal,
        List<QuestaoDto> Questoes,
        List<QuestaoRespondidaDto> Respondidas
        );
}
