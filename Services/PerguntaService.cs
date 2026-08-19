using System;
using System.Collections.Generic;
using System.Linq;
using SenacQuizApp.Repositories;
using SenacQuizApp.Enums;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Services
{
    public class PerguntaService
    {
        private readonly PerguntaRepository _perguntaRepository;

        public PerguntaService(PerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }

        public async Task<Quiz> CriarQuiz()
        {
            var perguntasAleatorias = await _perguntaRepository.ObterAleatorio(quantidade: 9);
            var perguntaAvancada = await _perguntaRepository.ObterAleatorio(quantidade: 1, nivel: PerguntaNivel.Avancado);

            List<Pergunta>? perguntas = [];
            perguntas.AddRange(perguntasAleatorias);
            perguntas.AddRange(perguntaAvancada);

            Quiz? quiz = new Quiz(DataCriacao: DateTime.UtcNow, Perguntas: perguntas);

            return quiz;
        }
    }
}
