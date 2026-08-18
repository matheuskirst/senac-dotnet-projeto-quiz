using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using SenacQuizApp.Banco.Repositories;
using SenacQuizApp.Entidades;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services
{
    public class QuizService
    {
        private readonly QuizRepository _quizRepository;
        private readonly PerguntaRepository _perguntaRepository;

        public QuizEncontrado QuizAtual { get; set; }

        public QuizService(QuizRepository quizRespository, PerguntaRepository perguntaRepository)
        {
            _quizRepository = quizRespository;
            _perguntaRepository = perguntaRepository;
        }

        //public async Task<BuscarQuizResposta> BuscarQuizHoje(int usuarioId)
        //{
        //    DateTime hoje = DateTime.Today;
        //    Quiz? quiz = await _quizRepository.ObterPorData(usuarioId, hoje);

        //    if (quiz == null)
        //    {
        //        await GerarQuizDto(quiz);
        //    }
        //    else if (quiz != null && quiz.DataConcluido == DateTime.Today)
        //    {
                

        //        return quizEncontrado;
        //    }
        //}

        //public async Task<QuizEncontrado> GerarQuiz()
        //{
        //    Quiz quiz = new Quiz();

        //    IEnumerable<Pergunta> perguntasAleatorias = await _perguntaRepository.ObterAleatorio(quantidade: 9);
        //    IEnumerable<Pergunta> perguntaAvancadaAleatoria = await _perguntaRepository.ObterAleatorio(quantidade: 1, nivel: PerguntaNivel.Avancado);

        //    List<QuizPergunta> quizPerguntas = [];

        //    foreach (Pergunta pergunta in perguntasAleatorias)
        //    {
        //        QuizPergunta qp = new QuizPergunta
        //        {
        //            Quiz = quiz,
        //            Pergunta = pergunta
        //        };
        //        quizPerguntas.Add(qp);
        //    }
            
        //    Pergunta? perguntaAvancada = perguntaAvancadaAleatoria.FirstOrDefault();
        //    if (perguntaAvancada != null)
        //    {
        //        QuizPergunta? quizPerguntaAvancada = new QuizPergunta { Quiz=quiz, Pergunta=perguntaAvancada };
        //        quizPerguntas.Add(quizPerguntaAvancada);
        //    }

        //    await _quizRepository.AdicionarQuiz(quiz);
        //}

        public async Task<QuizEncontrado> GerarQuizDto(Quiz quiz)
        {
            return new QuizEncontrado()
            {
                Id = quiz.Id,
                Concluido = quiz.Concluido,
                Perguntas = quiz.QuizPerguntas
                    .Select(qp => new PerguntasEncontradas
                    {
                        Id = qp.Pergunta.Id,
                        Enunciado = qp.Pergunta.Enunciado,
                        Alternativas = qp.Pergunta.Alternativas
                            .Select(pa => new AlternativaDto
                            {
                                Id = pa.Id,
                                Texto = pa.Texto
                            }).ToList()
                    }).ToList()
            };
        }

        public async Task ConcluiuQuiz(int usuarioId, int quizId)
        {

        }
    }
}
