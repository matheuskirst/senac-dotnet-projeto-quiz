using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Dtos
{
    public record VerificarQuizResponse(bool Existe, bool? IsConcluido=null, ErroQuiz? Erro=null);
}
