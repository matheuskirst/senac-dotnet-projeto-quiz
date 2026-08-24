using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Usuario
{
    public record AutenticacaoRequest(string Username, string Senha);
}
