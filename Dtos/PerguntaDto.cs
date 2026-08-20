using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public record PerguntaDto(
        int Id,
        string Enunciado,
        PerguntaTipo Tipo,
        List<AlternativaDto> Alternativas,
        bool Respondida
        );
}
