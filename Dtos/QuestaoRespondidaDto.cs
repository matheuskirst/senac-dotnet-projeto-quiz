using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public record QuestaoRespondidaDto(
        int Id,
        int QuestaoId,
        bool Acertou,
        int PontuacaoInicial,
        int Bonus,
        int PontuacaoFinal
        );
}
