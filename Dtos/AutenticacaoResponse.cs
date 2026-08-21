using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public record AutenticacaoResponse(bool IsSucesso, ErroAutenticacao? Erro=null);
}
