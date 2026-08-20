using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public record QuizDto(
        int Id,
        List<PerguntaDto> Perguntas
        );
}
