using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public record QuestaoDto(
        int Id,
        string Enunciado,
        QuestaoTemaId TemaId,
        string Tema,
        QuestaoTipoId TipoId,
        string Tipo,
        QuestaoNivelId NivelId,
        string Nivel,
        bool Respondida,
        List<AlternativaDto> Alternativas
        );
}
