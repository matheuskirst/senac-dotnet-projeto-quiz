using Microsoft.EntityFrameworkCore;
using SenacQuizApp.banco.config;
using SenacQuizApp.Banco.Entidades;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Banco.Repositories
{
    public class QuizRepository
    {
        public static async Task CriarQuiz(Quiz quiz)
        {
            using (var db = new AppContexto())
            {
                await db.Quizzes.AddAsync(quiz);
                await db.SaveChangesAsync();
            }
        }
        
        public static async Task AdicionarQuizPerguntas(List<QuizPergunta> quizPergunta)
        {
            using (var db = new AppContexto())
            {
                await db.QuizzesPerguntas.AddRangeAsync(quizPergunta);
                await db.SaveChangesAsync();
            }
        }

        public static async Task SalvarTentativa(QuizTentativa tentativa)
        {
            using (var db = new AppContexto())
            {
                await db.QuizzesTentativas.AddAsync(tentativa);
                await db.SaveChangesAsync();
            }
        }

        public static async Task SalvarResposta(PerguntaRespondida resposta)
        {
            using (var db = new AppContexto())
            {
                await db.PerguntasRespondidas.AddAsync(resposta);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<IEnumerable<Pergunta>> ObterPerguntasAleatorias(int quantidade, int? nivelId=null)
        {
            using (var db = new AppContexto())
            {
                IQueryable<Pergunta> query = db.Perguntas;

                if (nivelId != null && nivelId is int)
                {
                    query = query.Where(p => p.Nivel.Id == nivelId);
                }

                var perguntas = await query
                    .OrderBy(p => EF.Functions.Random())
                    .Take(quantidade)
                    .ToListAsync();

                return perguntas;
            }
        }

        public static async Task<QuizDto?> BuscarQuizDeHoje()
        {
            using (var db = new AppContexto())
            {
                var hoje = DateTime.Today;
                QuizDto? quiz = await db.Quizzes
                    .Where(q => q.DataExibicao == hoje)
                    .Select(q => new QuizDto {
                        Id = q.Id,
                        QuantidadePerguntas = q.QuantidadePerguntas,
                        Perguntas = q.QuizPerguntas.Select(qp => new PerguntaDto
                        {
                            Id = qp.Pergunta.Id,
                            Enunciado = qp.Pergunta.Enunciado,
                            Tipo = qp.Pergunta.Tipo,
                            Nivel = qp.Pergunta.Nivel,
                            Tema = qp.Pergunta.Tema,
                            Alternativas = qp.Pergunta.Alternativas.Select(pa => new AlternativaDto
                            {
                                Id = pa.Id,
                                Texto = pa.Texto
                            }).ToList(),
                        }).ToList()
                    })
                    .FirstOrDefaultAsync();
                return quiz;
            }
        }

        public static async Task<Alternativa?> BuscarAlternativa(int idAlternativa)
        {
            using (var db = new AppContexto())
            {
                Alternativa? alternativa = await db.Alternativas.FindAsync(idAlternativa);
                return alternativa;
            }
        }

        public static async Task<QuizTentativa?> BuscarTentativa(int usuarioId, int quizId)
        {
            using (var db = new AppContexto())
            {
                QuizTentativa? tentativa = await db.QuizzesTentativas
                    .Where(qt => qt.UsuarioId == usuarioId && qt.QuizId == quizId)
                    .FirstOrDefaultAsync();
                return tentativa;
            }
        }
    }
}
