using SenacQuizApp.Data;
using SenacQuizApp.Repositories;
using SenacQuizApp.Dtos.Quiz;
using SenacQuizApp.Dtos.Quiz.Concluido;
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
using System.Security.Cryptography.X509Certificates;

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

            if (quiz == null)
            {
                quiz = await CriarQuiz(usuarioId);
            }

            var questoesDto = quiz.Questoes.Select(questao => new QuestaoDto
            {
                Id = questao.Id,
                Enunciado = questao.Enunciado,
                TipoId = questao.TipoId,
                Pontos = questao.Nivel.Pontos,
                Respondida = quiz.UsuarioRespostas.Any(ur => ur.UsuarioId == UsuarioAtual.Id && ur.QuizId == quiz.Id && ur.QuestaoId == questao.Id),
                Alternativas = questao.Alternativas.Select(alternativa => new AlternativaDto
                {
                    Id = alternativa.Id,
                    Texto = alternativa.Texto,
                }).OrderBy(a => Guid.NewGuid()).ToList()
            }).ToList();

            var quizDto = new QuizDto
            {
                Id = quiz.Id,
                DataExibido = quiz.DataExibido,
                FoiConcluido = quiz.FoiConcluido,
                PontuacaoTotal = quiz.PontuacaoTotal,
                Questoes = questoesDto
            };

            return quizDto;
        }

        public async Task<QuizConcluidoDto?> ObterQuiz(int quizId)
        {
            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            Quiz? quiz = await _quizRepository.ObterPorId(quizId);

            if (quiz == null)
            {
                return null;
            }

            var questoesConcluidasDto = quiz.Questoes.Select(questao => new QuestaoConcluidaDto
            {
                Id = questao.Id,
                Enunciado = questao.Enunciado,
                TemaId = questao.TemaId,
                Tema = questao.Tema.Nome,
                NivelId = questao.NivelId,
                Nivel = questao.Nivel.Nome,
                TipoId = questao.TipoId,
                Tipo = questao.Tipo.Nome,
                Pontos = quiz.UsuarioRespostas
                    .Where(ur =>
                        ur.UsuarioId == UsuarioAtual.Id
                        && ur.QuizId == quiz.Id
                        && ur.QuestaoId == questao.Id)
                    .Select(ur => ur.PontuacaoFinal)
                    .FirstOrDefault(),
                Acertou = quiz.UsuarioRespostas
                    .Where(ur =>
                        ur.UsuarioId == UsuarioAtual.Id
                        && ur.QuizId == quiz.Id
                        && ur.QuestaoId == questao.Id)
                    .Select(ur => ur.Acertou)
                    .FirstOrDefault(),
            }).ToList();

            var quizConcluidoDto = new QuizConcluidoDto
            {
                Id = quiz.Id,
                DataInicio = quiz.DataInicio,
                DataExibido = quiz.DataExibido,
                FoiConcluido = quiz.FoiConcluido,
                DataConcluido = quiz.DataConcluido,
                TempoDeConclusao = quiz.TempoDeConclusao,
                TotalQuestoes = quiz.Questoes.Count(),
                TotalAcertos = quiz.UsuarioRespostas
                    .Count(ur => ur.Acertou == true),
                PontuacaoTotal = quiz.PontuacaoTotal,
                Questoes = questoesConcluidasDto
            };

            return quizConcluidoDto;
        }

        public async Task<bool> SalvarResposta(int quizId, QuestaoDto questao, int sequenciaAcertos, int? alternativaId = null, bool? verdadeiro = null)
        {
            int usuarioId = UsuarioAtual.Id;
            UsuarioStats? usuarioStats = await _usuarioRepository.ObterStatsPorId(usuarioId);
            Quiz? quiz = await _quizRepository.ObterPorId(quizId);
            bool correta = false;
            int pontos = questao.Pontos;
            int bonus = 0;
            int pontuacaoFinal = 0;

            if (alternativaId != null && verdadeiro == null)
            {
                correta = await _questaoRepository.VerificarAlternativa(alternativaId);
            }            
            
            if (verdadeiro != null && alternativaId == null)
            {
                correta = await _questaoRepository.VerificarVerdadeiroFalso(questao.Id, verdadeiro);
            }

            if (correta)
            {
                if (sequenciaAcertos >= 5)
                {
                    bonus = 20;
                }
                else if (sequenciaAcertos >= 3)
                {
                    bonus = 10;
                }

                pontuacaoFinal = pontos + (pontos * bonus) / 100;
            }

            if (usuarioStats != null)
            {
                usuarioStats.AtualizarAcertos(correta);
                usuarioStats.AdicionarPontos(pontuacaoFinal);
            }

            if (quiz != null)
            {
                quiz.PontuacaoTotal += pontuacaoFinal;
            }

            var usuarioResposta = new UsuarioResposta
            {
                UsuarioId = usuarioId,
                QuizId = quizId,
                QuestaoId = questao.Id,
                Acertou = correta,
                PontuacaoFinal = pontuacaoFinal,
                DataDeResposta = DateTime.UtcNow
            };

            _questaoRepository.AdicionarResposta(usuarioResposta);

            await _contexto.SaveChangesAsync();
            return correta;
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
