using Microsoft.EntityFrameworkCore;
using SenacQuizApp.banco.config;
using SenacQuizApp.Entidades;
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
                db.Quizzes.Add(quiz);
                await db.SaveChangesAsync();
            }
        }

        public static async Task SalvarResposta(PerguntaRespondida resposta)
        {
            using (var db = new AppContexto())
            {
                db.PerguntasRespondidas.Add(resposta);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<IEnumerable<Quiz>> ObterPerguntas()
        {
            using (var db = new AppContexto())
            {
                var quizzes = await db.Quizzes
                    .OrderBy(u => u.Id)
                    .ToListAsync();

                return quizzes;
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
    }
}
