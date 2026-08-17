using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services.Enums
{
    public class MensagemErro
    {
        private MensagemErro(string valor) { Valor = valor; }

        public string Valor { get; set; }

        public static MensagemErro NomeIndisponivel { get; } = new MensagemErro("Esse nome não está disponível!");
        public static MensagemErro LoginInvalido { get; } = new MensagemErro("Nome ou senha estão errados.");
    }
}
