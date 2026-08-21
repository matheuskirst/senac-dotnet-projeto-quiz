using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Enums
{
    public class ErroQuiz
    {
        private ErroQuiz(string valor) { Valor = valor; }

        public string Valor { get; set; }

        public static ErroQuiz QuizInvalido { get; } = new("Não foi possível encontrar ou criar um quiz.");
        public static ErroQuiz QuizJaConcluido { get; } = new("Esse Quiz já foi concluído.");
        public static ErroQuiz RespostaInvalida { get; } = new("Não foi possível salvar a resposta.");
    }
}
