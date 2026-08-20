using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Enums
{
    public class Mensagem
    {
        private Mensagem(string valor) { Valor = valor; }

        public string Valor { get; set; }

        public static Mensagem NomeIndisponivelErro { get; } = new("Esse nome não está disponível!");
        public static Mensagem LoginInvalidoErro { get; } = new("Nome ou senha estão errados.");
        public static Mensagem QuizInvalidoErro { get; } = new("Não foi possível encontrar ou criar um quiz.");
        public static Mensagem QuizJaConcluidoErro { get; } = new("Esse Quiz já foi concluído.");
        public static Mensagem SalvarRespostaErro { get; } = new("Não foi possível salvar a resposta.");
    }
}
