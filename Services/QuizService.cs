using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos.Quiz;
using SenacQuizApp.Dtos.Quiz.Historico;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.Services
{
    public class QuizService
    {
        private readonly QuizAppContexto _contexto;

        public QuizService(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<QuizDiario?> CriarQuizDiario(int usuarioId)
        {
            var questaoAvancada = _contexto.Questoes
                .Where(q => q.NivelId == QuestaoNivelId.Avancado)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .OrderBy(q => Guid.NewGuid())
                .FirstOrDefault();

            var questoes = questaoAvancada != null ? new List<Questao> { questaoAvancada } : new List<Questao>();

            int? idAvancada = questaoAvancada?.Id;

            var questoesAleatorias = await _contexto.Questoes
                .Where(q => q.Id != idAvancada)
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .OrderBy(q => Guid.NewGuid())
                .Take(9)
                .ToListAsync();

            questoes.AddRange(questoesAleatorias);

            var agoraLocal = ObterHora.ObterHoraBrasilia();
            var hoje = DateOnly.FromDateTime(agoraLocal);

            QuizDiario novoQuiz = new()
            {
                UsuarioId = usuarioId,
                DataExibido = hoje,
                Questoes = questoes
            };

            _contexto.Quizzes.Add(novoQuiz);
            await _contexto.SaveChangesAsync();

            QuizDiario? quizCriado = await _contexto.Quizzes
                .QuizDadosCompletos()
                .FirstOrDefaultAsync(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje); ;

            return quizCriado;
        }

        public async Task<QuizDto?> ObterQuiz(int quizId)
        {
            int usuarioId = UsuarioAtual.Id;

            QuizDto? quizDto = await _contexto.Quizzes
                .Where(quiz => quiz.Id == quizId)
                .Select(quiz => new QuizDto
                {
                    Id = quiz.Id,
                    FoiConcluido = quiz.FoiConcluido,
                    PontuacaoTotal = quiz.PontuacaoTotal,
                    Questoes = quiz.Questoes.Select(questao => new QuestaoDto
                    {
                        Id = questao.Id,
                        Enunciado = questao.Enunciado,
                        TemaId = questao.TemaId,
                        Tema = questao.Tema.Nome,
                        NivelId = questao.NivelId,
                        Nivel = questao.Nivel.Nome,
                        TipoId = questao.TipoId,
                        Tipo = questao.Tipo.Nome,
                        Pontos = questao.Nivel.Pontos,
                        Respondida = quiz.UsuarioRespostas.Any(ur => 
                            ur.QuizId == quizId
                            && ur.UsuarioId == usuarioId
                            && ur.QuestaoId == questao.Id
                            ),
                        Acertou = quiz.UsuarioRespostas
                            .Where(ur =>
                                ur.QuizId == quizId
                                && ur.UsuarioId == usuarioId
                                && ur.QuestaoId == questao.Id
                                )
                            .Select(ur => (bool?)ur.Acertou)
                            .FirstOrDefault(),
                        Alternativas = questao.Alternativas.Select(alternativa => new AlternativaDto
                        {
                            Id = alternativa.Id,
                            Texto = alternativa.Texto
                        }).ToList()
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (quizDto != null)
            {
                var rng = new Random();

                foreach(var questao in quizDto.Questoes)
                {
                    if (questao.Alternativas != null)
                    {
                        questao.Alternativas = questao.Alternativas.OrderBy(_ => rng.Next()).ToList();
                    }
                }
            }

            return quizDto;
        }

        public async Task<QuizDto?> ObterQuizDiario()
        {
            int usuarioId = UsuarioAtual.Id;
            var hoje = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());

            QuizDiario? quiz = await _contexto.Quizzes
                .QuizDadosCompletos()
                .FirstOrDefaultAsync(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == hoje); ;

            if (quiz == null)
            {
                quiz = await CriarQuizDiario(usuarioId);
            }

            var questoesDto = quiz.Questoes.Select(questao => new QuestaoDto
            {
                Id = questao.Id,
                Enunciado = questao.Enunciado,
                TemaId = questao.TemaId,
                Tema = questao.Tema.Nome,
                NivelId = questao.NivelId,
                Nivel = questao.Nivel.Nome,
                TipoId = questao.TipoId,
                Tipo = questao.Tipo.Nome,
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

        public async Task<QuizHistoricoDto?> ObterQuizConcluido(int quizId)
        {
            int usuarioId = UsuarioAtual.Id;

            QuizHistoricoDto? quizConcluidoDto = await _contexto.Quizzes
                .Where(quiz => quiz.Id == quizId)
                .QuizHistorico()
                .FirstOrDefaultAsync();

            if (quizConcluidoDto == null)
            {
                return null;
            }

            return quizConcluidoDto;
        }

        public async Task<bool> SalvarResposta(int quizId, QuestaoDto questao, int sequenciaAcertos, int? alternativaId = null, bool? verdadeiro = null)
        {
            int usuarioId = UsuarioAtual.Id;
            UsuarioStats? usuarioStats = await _contexto.UsuarioStats
                .FirstOrDefaultAsync(s => s.Id == usuarioId); ;
            QuizDiario? quiz = await _contexto.Quizzes
                .QuizDadosCompletos()
                .FirstOrDefaultAsync(quiz => quiz.Id == quizId);

            bool correta = false;
            int pontos = questao.Pontos;
            int bonus = 0;
            int pontuacaoFinal = 0;

            if (alternativaId != null && verdadeiro == null)
            {
                correta = await _contexto.Alternativas
                .Where(a => a.Id == alternativaId)
                .Select(a => a.IsCorreta)
                .FirstOrDefaultAsync();
            }
            
            if (verdadeiro != null && alternativaId == null)
            {
                correta = await _contexto.Questoes
                .Where(q => q.Id == questao.Id)
                .Select(q => q.Verdadeira == verdadeiro)
                .FirstOrDefaultAsync();
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

            var resposta = new UsuarioResposta
            {
                UsuarioId = usuarioId,
                QuizId = quizId,
                QuestaoId = questao.Id,
                Acertou = correta,
                PontuacaoFinal = pontuacaoFinal,
                DataDeResposta = DateTime.UtcNow
            };

            _contexto.UsuarioRespostas.Add(resposta);

            await _contexto.SaveChangesAsync();
            return correta;
        }

        public async Task ConcluirQuiz(int quizId)
        {
            QuizDiario? quiz = await _contexto.Quizzes
                .QuizDadosCompletos()
                .FirstOrDefaultAsync(quiz => quiz.Id == quizId);

            if (quiz == null) return;

            quiz.Concluir();
            _contexto.Quizzes.Update(quiz);
            await _contexto.SaveChangesAsync();
        }
    }

    public static class QuizQueryExtensoes
    {
        public static IQueryable<QuizDiario> QuizDadosCompletos(this IQueryable<QuizDiario> query)
        {
            return query
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Tema)
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Nivel)
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Tipo)
                .Include(quiz => quiz.Questoes).ThenInclude(q => q.Alternativas)
                .Include(quiz => quiz.UsuarioRespostas)
                .AsSplitQuery();
        }

        public static IQueryable<QuizHistoricoDto> QuizHistorico(this IQueryable<QuizDiario> query)
        {
            return query
                .Select(quiz => new QuizHistoricoDto
                {
                    Id = quiz.Id,
                    DataInicio = quiz.DataInicio,
                    DataExibido = quiz.DataExibido,
                    FoiConcluido = quiz.FoiConcluido,
                    DataConcluido = quiz.DataConcluido,
                    TempoDeConclusao = quiz.TempoDeConclusao,
                    TotalQuestoes = quiz.Questoes.Count(),
                    TotalAcertos = quiz.UsuarioRespostas.Count(ur => ur.Acertou == true),
                    PontuacaoTotal = quiz.PontuacaoTotal,
                    Questoes = quiz.Questoes.Select(questao => new QuestaoHistoricoDto
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
                            .Where(ur => ur.UsuarioId == UsuarioAtual.Id
                                      && ur.QuizId == quiz.Id
                                      && ur.QuestaoId == questao.Id)
                            .Select(ur => ur.PontuacaoFinal)
                            .FirstOrDefault(),

                        Acertou = quiz.UsuarioRespostas
                            .Where(ur => ur.UsuarioId == UsuarioAtual.Id
                                      && ur.QuizId == quiz.Id
                                      && ur.QuestaoId == questao.Id)
                            .Select(ur => (bool?)ur.Acertou)
                            .FirstOrDefault(),

                        Alternativas = questao.Alternativas.Select(alternativa => new AlternativaHistoricoDto
                        {
                            Id = alternativa.Id,
                            Texto = alternativa.Texto,
                            Correta = alternativa.IsCorreta
                        }).ToList()
                    }).ToList()
                });

        }
    }
}
