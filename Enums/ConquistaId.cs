using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Enums
{
    public enum ConquistaId
    {
        PrimeiroQuizConcluido = 1,
        DezAcertosSeguidos = 2,

        MestreHardware = 3,
        MestreProgramacao = 4,
        MestreRedes = 5,
        MestreSegurancaDigital = 6,
        MestreSistemasOperacionais = 7,
        MestreFerramentasDeProdutividade = 8,

        AcessouPor3DiasSeguidos = 9,
        AcessouPor7DiasSeguidos = 10,
        AcessouPor30DiasSeguidos = 11,
        AcessouPor90DiasSeguidos = 12,
        AcessouPor365DiasSeguidos = 13
    }
}
