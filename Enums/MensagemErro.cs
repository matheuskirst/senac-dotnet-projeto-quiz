using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Enums
{
    public class MensagemErro
    {
        private MensagemErro(string valor) { Valor = valor; }

        public string Valor { get; set; }

        public static MensagemErro NomeIndisponivel { get; } = new("Esse nome não está disponível!");
        public static MensagemErro LoginInvalido { get; } = new("Nome ou senha estão errados.");
        public static MensagemErro QuizInvalido { get; } = new("Quiz não encontrado.");
        public static MensagemErro QuizConcluido { get; } = new("O quiz diário já foi conclúido!");
    }
}
