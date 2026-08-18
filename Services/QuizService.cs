using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using SenacQuizApp.Banco.Entidades;
using SenacQuizApp.Banco.Repositories;
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
        public async Task<QuizDto?> ObterQuizDiario()
        {
            QuizDto? quiz = await QuizRepository.BuscarQuizDeHoje();

            if (quiz != null)
            {
                QuizDto quizDto = new QuizDto
                {
                    Id = quiz.Id,
                    QuantidadePerguntas = quiz.QuantidadePerguntas,
                    Perguntas = quiz.Perguntas
                };

                return quizDto;
            }
            else
            {
                return null;
            }
        }

        public async Task CriarQuizDiario()
        {
            Quiz quiz = new Quiz();

            int quantidadePerguntas = quiz.QuantidadePerguntas - 1;

            IEnumerable<Pergunta> perguntasAleatorias = await QuizRepository.ObterPerguntasAleatorias(quantidade: quantidadePerguntas);
            IEnumerable<Pergunta> perguntaAvancada = await QuizRepository.ObterPerguntasAleatorias(quantidade: 1, nivelId: 4);

            List<QuizPergunta> quizPerguntas = [];

            foreach (Pergunta pergunta in perguntasAleatorias)
            {
                QuizPergunta qp = new QuizPergunta
                {
                    Quiz = quiz,
                    Pergunta = pergunta
                };
                quizPerguntas.Add(qp);
            }
            
            QuizPergunta? quizPerguntaAvancada = new QuizPergunta { Quiz=quiz, Pergunta=perguntaAvancada.FirstOrDefault() };
            quizPerguntas.Add(quizPerguntaAvancada);

            await QuizRepository.CriarQuiz(quiz);
            await QuizRepository.AdicionarQuizPerguntas(quizPerguntas);

        }

        public async Task IniciouQuiz(int usuarioId, int quizId)
        {
            QuizTentativa tentativa = new QuizTentativa()
            {
                UsuarioId = usuarioId,
                QuizId = quizId,
                Concluido = false,
                PontuacaoFinal = null
            };
            await QuizRepository.SalvarTentativa(tentativa);
        }

        public async Task ConcluiuQuiz(int usuarioId, int quizId)
        {
            QuizTentativa? tentativa = await QuizRepository.BuscarTentativa(usuarioId, quizId);
            if (tentativa != null)
            {
                tentativa.Concluido = true;
                await QuizRepository.SalvarTentativa(tentativa);
            }
        }

        public async Task<bool> VerificarQuizRealizado(int usuarioId, int quizId)
        {
            QuizTentativa? tentativa = await QuizRepository.BuscarTentativa(usuarioId, quizId);
            if (tentativa != null && tentativa.Concluido == true)
            {
                return true;
            }
            else { return false; }
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
