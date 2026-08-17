using SenacQuizApp.Banco.Repositories;
using SenacQuizApp.Entidades;
using SenacQuizApp.Modelos;
using SenacQuizApp.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services
{
    public class ResultadoResposta(bool ehCorreta, MensagemErro? mensagemErro=null)
    {
        public bool EhCorreta { get; set; } = ehCorreta;
        public MensagemErro? MensagemErro { get; set; } = mensagemErro;
    }

    public class QuizService
    {
        public async Task CriarQuiz()
        {
            Quiz quiz = new Quiz();
        }

        public async Task<ResultadoResposta> EnviarResposta(QuizTentativa quizTentativa, int alternativaId)
        {
            var resultado = new ResultadoResposta(ehCorreta:false);

            Alternativa? alternativa = await QuizRepository.BuscarAlternativa(alternativaId);
            Pergunta? pergunta = alternativa.Pergunta;

            if (alternativa != null && alternativa.EhCorreta) { resultado.EhCorreta = true; }

            PerguntaRespondida resposta = new PerguntaRespondida
            {
                QuizTentativa = quizTentativa,
                Pergunta = pergunta,
            };

            return resultado;
        }
    }
}
