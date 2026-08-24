using SenacQuizApp.Data;
using SenacQuizApp.Repositories;
using SenacQuizApp.Dtos.Quiz;
using SenacQuizApp.Modelos;
using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SenacQuizApp.Global;

namespace SenacQuizApp.Services
{
    public class QuizService
    {
        private readonly QuizAppContexto _contexto;
        private readonly QuizRepository _quizRepository;
        private readonly QuestaoRepository _questaoRepository;
        private readonly UsuarioRepository _usuarioRepository;


        public QuizService(
            QuizAppContexto contexto, 
            QuizRepository quizRepository,
            QuestaoRepository questaoRepository,
            UsuarioRepository usuarioRepository
            )
        {
            _contexto = contexto;
            _quizRepository = quizRepository;
            _questaoRepository = questaoRepository;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Quiz?> CriarQuiz(int usuarioId)
        {
            List<Questao> questesAleatorias = await _questaoRepository.ObterQuestoesParaQuiz();

            var agoraLocal = ObterHora.ObterHoraBrasilia();
            var hoje = DateOnly.FromDateTime(agoraLocal);

            Quiz novoQuiz = new()
            {
                UsuarioId = usuarioId,
                DataExibido = hoje,
                Questoes = questesAleatorias
            };

            _quizRepository.Adicionar(novoQuiz);
            await _contexto.SaveChangesAsync();

            Quiz? quizCriado = await _quizRepository.ObterPorUsuarioIdEData(usuarioId, hoje);

            return quizCriado;
        }

        public async Task<QuizDto?> ObterQuizDiario()
        {
            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            Quiz? quiz = await _quizRepository.ObterPorUsuarioIdEData(usuarioId, hoje);
            UsuarioStats? usuarioStats = await _usuarioRepository.ObterStatsPorId(usuarioId);

            if (quiz == null)
            {
                quiz = await CriarQuiz(usuarioId);
            }

            var questoesDto = quiz.Questoes.Select(questao => new QuestaoDto
            {
                Id = questao.Id,
                Enunciado = questao.Enunciado,
                Tipo = questao.TipoId,
                Respondida = quiz.UsuarioRespostas.Any(ur => ur.UsuarioId == UsuarioAtual.Id && ur.QuizId == quiz.Id && ur.QuestaoId == questao.Id),
                Alternativas = questao.Alternativas.Select(alternativa => new AlternativaDto
                {
                    Id = alternativa.Id,
                    Texto = alternativa.Texto,
                }).ToList()
            }).ToList();

            var quizDto = new QuizDto(QuizId: quiz.Id, DataExibido: quiz.DataExibido, FoiConcluido: quiz.FoiConcluido, PontuacaoTotal: quiz.PontuacaoTotal, Questoes: questoesDto);

            return quizDto;
        }

        public async Task<bool> SalvarResposta(int quizId, int questaoId, int pontuacaoInicial, bool acertou, int bonus, int PontuacaoFinal)
        {
            UsuarioStats? usuarioStats = await _usuarioRepository.ObterStatsPorId(UsuarioAtual.Id);

            if (usuarioStats == null) return false;

            usuarioStats.AtualizarAcertos(acertou);

            UsuarioResposta resposta = new()
            {
                UsuarioId = UsuarioAtual.Id,
                QuizId = quizId,
                QuestaoId = questaoId,
                PontuacaoInicial = pontuacaoInicial,
                Acertou = acertou,
                Bonus = bonus,
                PontuacaoFinal = pontuacaoInicial
            };

            _questaoRepository.AdicionarResposta(resposta);
            await _contexto.SaveChangesAsync();
            return isCorreta;
        }

        public async Task ConcluirQuiz(int quizId)
        {
            Quiz? quiz = await _quizRepository.ObterPorId(quizId);

            if (quiz == null) return;

            quiz.Concluir();
            _quizRepository.Atualizar(quiz);
            await _contexto.SaveChangesAsync();
        }
    }
}
