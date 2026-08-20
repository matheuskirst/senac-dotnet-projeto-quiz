using SenacQuizApp.Data;
using SenacQuizApp.Repositories;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos;
using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace SenacQuizApp.Services
{
    public class QuizExecucaoService
    {
        private readonly QuizAppContexto _contexto;
        private readonly QuizRepository _quizRepository;
        private readonly PerguntaRepository _perguntaRepository;
        private readonly AlternativaRepository _alternativaRepository;
        private readonly UsuarioRepository _usuarioRepository;

        private int SequenciaAcertos = 0;

        public QuizExecucaoService(
            QuizAppContexto contexto, 
            QuizRepository quizRepository,
            PerguntaRepository perguntaRepository, 
            AlternativaRepository alternativaRepository,
            UsuarioRepository usuarioRepository
            )
        {
            _contexto = contexto;
            _quizRepository = quizRepository;
            _perguntaRepository = perguntaRepository;
            _alternativaRepository = alternativaRepository;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Quiz> CriarQuiz(int usuarioId)
        {
            List<Pergunta> perguntasAleatorias = await _perguntaRepository.ObterAleatorio(quantidade: 9);
            List<Pergunta> perguntaAvancada = await _perguntaRepository.ObterAleatorioPorNivel(quantidade: 1, nivel: PerguntaNivel.Avancado);

            Quiz quiz = new()
            {
                UsuarioId = usuarioId,
                Perguntas = [.. perguntasAleatorias, .. perguntaAvancada]
            };

            await _quizRepository.Adicionar(quiz);
            await _contexto.SaveChangesAsync();
            return quiz;
        }

        public async Task<ObterQuizResponse> ObterQuizDiario(int usuarioId)
        {
            SequenciaAcertos = 0;
            try
            {
                // Verifica se existe um quiz criado hoje
                var hoje = DateTime.Today;
                List<Quiz> quizzes = await _quizRepository.ObterPorUsuarioIdEData(usuarioId, hoje);
                Quiz? quiz = quizzes.FirstOrDefault();

                // Se quiz não existe, criar e retornar um quiz novo
                if (quiz == null)
                {
                    quiz = await CriarQuiz(usuarioId);

                    QuizDto quizDto = CriarQuizDto(quiz);
                    return new ObterQuizResponse(IsSucesso: true, Data: quizDto);
                }
                // Se quiz existe mas não foi concluido, retorna quiz inconcluso
                else if (quiz != null && quiz.IsConcluido == false)
                {
                    QuizDto quizDto = CriarQuizDto(quiz);
                    return new ObterQuizResponse(IsSucesso: true, Data: quizDto);
                }
                // Se quiz existe e foi concluido, retorna mensagem 'quiz já concluido'
                else if (quiz != null && quiz.IsConcluido)
                {
                    return new ObterQuizResponse(IsSucesso: false, Mensagem: Mensagem.QuizJaConcluidoErro);
                }
                else
                {
                    return new ObterQuizResponse(IsSucesso: false, Mensagem: Mensagem.QuizInvalidoErro);
                }
            }
            catch
            {
                return new ObterQuizResponse(IsSucesso: false, Mensagem: Mensagem.QuizInvalidoErro);
            }
        }

        private QuizDto CriarQuizDto(Quiz quiz)
        {
            List<PerguntaDto> perguntasDtos = [];

            foreach (Pergunta pergunta in quiz.Perguntas)
            {
                List<AlternativaDto> alternativasDtos = [];
                foreach (Alternativa alternativa in pergunta.Alternativas)
                {
                    AlternativaDto alternativaDto = new(Id: alternativa.Id, Texto: alternativa.Texto);
                    alternativasDtos.Add(alternativaDto);
                }

                bool respondeuPergunta = false;
                foreach(PerguntaRespondida resposta in quiz.PerguntasRespondidas)
                {
                    if (pergunta.Id == resposta.Pergunta.Id)
                    {
                        respondeuPergunta = true;
                    }
                }

                PerguntaDto perguntaDto = new(
                    Id: pergunta.Id,
                    Enunciado: pergunta.Enunciado,
                    Tipo: pergunta.Tipo,
                    Alternativas: alternativasDtos,
                    Respondida: respondeuPergunta
                    );
                perguntasDtos.Add(perguntaDto);
            }

            QuizDto quizDto = new(Id: quiz.Id, Perguntas: perguntasDtos);

            return quizDto;
        }

        public async Task<NovaRespostaResponse> AdicionarResposta(NovaRespostaRequest respostaDto)
        {
            int usuarioId = UsuarioAtual.Id;
            int quizId = respostaDto.QuizId;
            int perguntaId = respostaDto.PerguntaId;
            int alternativaId = respostaDto.AlternativaId;

            try
            {
                Usuario? usuario = await _usuarioRepository.ObterPorId(usuarioId);
                Pergunta? pergunta = await _perguntaRepository.ObterPorId(perguntaId);
                Alternativa? alternativa = await _alternativaRepository.ObterPorId(alternativaId);

                if (usuario == null || pergunta == null || alternativa == null)
                    return new NovaRespostaResponse(IsSucesso: false, Mensagem: Mensagem.SalvarRespostaErro);


                bool acertou = alternativa.IsCorreta;

                if (acertou) { SequenciaAcertos += 1; }
                else { SequenciaAcertos = 0; }

                int pontos = 0;

                switch (pergunta.Nivel)
                {
                    case PerguntaNivel.Iniciante:
                        pontos += 10;
                        break;
                    case PerguntaNivel.Facil:
                        pontos += 20;
                        break;
                    case PerguntaNivel.Intermediario:
                        pontos += 30;
                        break;
                    case PerguntaNivel.Avancado:
                        pontos += 50;
                        break;
                }

                int bonus = 10;

                if (SequenciaAcertos >= 5)
                {
                    bonus = 20;
                }
                else if (SequenciaAcertos >= 3)
                {
                    bonus = 10;
                }
                else
                {
                    bonus = 0;
                }

                pontos += pontos * (bonus / 100);

                PerguntaRespondida resposta = new()
                {
                    QuizId = quizId,
                    PerguntaId = perguntaId,
                    Acertou = acertou,
                    PontuacaoFinal = pontos
                };

                try
                {
                    await _perguntaRepository.SalvarResposta(resposta);
                    usuario.AdicionarPontos(pontos);
                    return new NovaRespostaResponse(IsSucesso: true);
                }
                catch
                {
                    return new NovaRespostaResponse(IsSucesso: false);
                }
            }
            catch
            {
                return new NovaRespostaResponse(IsSucesso: false);
            }

        }

        public async Task<ObterQuizResponse> ConcluirQuiz(int quizId)
        {
            Quiz quiz = await _quizRepository.ObterPorId(quizId);

            int pontuacaoTotal = 0;

            foreach(PerguntaRespondida resposta in quiz.PerguntasRespondidas)
            {
                pontuacaoTotal += resposta.PontuacaoFinal;
            }

            quiz.Concluir(pontuacaoTotal);
            await _quizRepository.Atualizar(quiz);
            await _contexto.SaveChangesAsync();

            QuizDto quizDto = CriarQuizDto(quiz);
            return new ObterQuizResponse(IsSucesso: true, Data: quizDto);
        }
    }
}
