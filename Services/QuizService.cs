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

        public async Task<QuizDto> ObterQuizDiario()
        {
            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            Quiz? quiz = await _quizRepository.ObterPorUsuarioIdEData(usuarioId, hoje);
            UsuarioStats? usuarioStats = await _usuarioRepository.ObterStatsPorId(usuarioId);

            if (quiz == null)
            {
                quiz = await CriarQuiz(usuarioId);
            }

            var questoessDtos = quiz.Questoes.Select(questao => new QuestaoDto(
                Id: questao.Id,
                Enunciado: questao.Enunciado,
                TemaId: questao.TemaId,
                Tema: questao.Tema.Nome,
                TipoId: questao.TipoId,
                Tipo: questao.Tipo.Nome,
                NivelId: questao.NivelId,
                Nivel: questao.Nivel.Nome,
                Respondida: quiz.UsuarioRespostas.Any(qr =>qr.QuizId == quiz.Id && qr.UsuarioId == usuarioId && qr.QuestaoId == questao.Id),
                Alternativas: questao.Alternativas.Select(alternativa => new AlternativaDto(
                    Id: alternativa.Id,
                    Texto: alternativa.Texto
                )).ToList()
            )).ToList();

            var respostasDtos = quiz.UsuarioRespostas.Select(resposta => new QuestaoRespondidaDto(
                Id: resposta.Id,
                QuestaoId: resposta.QuestaoId,
                Acertou: resposta.Acertou,
                PontuacaoInicial: resposta.PontuacaoInicial,
                Bonus: resposta.Bonus,
                PontuacaoFinal: resposta.PontuacaoFinal
            )).ToList();

            QuizDto quizDto = new(
                Id: quiz.Id,
                IsConcluido: quiz.IsConcluido,
                TempoDeConclusao: quiz.TempoDeConclusao,
                PontuacaoTotal: quiz.PontuacaoTotal,
                Questoes: questoessDtos,
                Respondidas: respostasDtos
                );

            return quizDto;
        }

        public async Task<bool> SalvarResposta(QuizDto quiz, QuestaoDto questao, int sequenciaAcertos, int? alternativaId = null, bool? verdadeiro = null)
        {
            UsuarioStats? usuarioStats = await _usuarioRepository.ObterStatsPorId(UsuarioAtual.Id);

            if (usuarioStats == null) return false;

            int pontos = 0;
            int bonus = 0;
            bool isCorreta = false;

            switch (questao.NivelId)
            {
                case QuestaoNivelId.Iniciante:
                    pontos += 10;
                    break;
                case QuestaoNivelId.Facil:
                    pontos += 20;
                    break;
                case QuestaoNivelId.Intermediario:
                    pontos += 30;
                    break;
                case QuestaoNivelId.Avancado:
                    pontos += 50;
                    break;
            }

            // Bônus em %
            if (sequenciaAcertos >= 5)
            {
                bonus = 20 ;
            }
            else if (sequenciaAcertos >= 3)
            {
                bonus = 10;
            }
            else
            {
                bonus = 0;
            }

            int pontosBonus = pontos + (pontos * bonus) / 100;

            if (questao.TipoId == QuestaoTipoId.Alternativas && alternativaId != null)
            {
                isCorreta = await _questaoRepository.VerificarAlternativa(alternativaId);

            }

            if (questao.TipoId == QuestaoTipoId.VerdadeiroOuFalso && verdadeiro != null)
            {
                isCorreta = await _questaoRepository.VerificarVerdadeiroFalso(questao.Id, verdadeiro);
            }

            if (isCorreta) 
            { 
                usuarioStats.AdicionarPontos(pontosBonus); 
            }
            else
            {
                bonus = 0;
                pontosBonus = 0;
            }

            usuarioStats.AtualizarAcertos(isCorreta);

            UsuarioResposta resposta = new()
            {
                UsuarioId = UsuarioAtual.Id,
                QuizId = quiz.Id,
                QuestaoId = questao.Id,
                PontuacaoInicial = pontos,
                Acertou = isCorreta,
                Bonus = bonus,
                PontuacaoFinal = pontosBonus
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
