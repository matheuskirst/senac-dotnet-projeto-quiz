using Microsoft.EntityFrameworkCore;
using SenacQuizApp.banco.config;
using SenacQuizApp.Entidades;
using SenacQuizApp.Enums;
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
        private readonly QuizAppContexto _contexto;
        public QuizRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Quiz?> ObterPorQuizId(int quizId)
        {
            return await _contexto.Quizzes
                .Include(q => q.Usuario)
                .Include(q => q.QuizPerguntas)
                    .ThenInclude(qp => qp.Pergunta)
                .FirstOrDefaultAsync(q => q.UsuarioId == quizId);
        }

        public async Task<Quiz?> ObterPorData(int usuarioId, DateTime data)
        {
            return await _contexto.Quizzes
                .Include(q => q.Usuario)
                .Include(q => q.QuizPerguntas)
                    .ThenInclude(qp => qp.Pergunta)
                .FirstOrDefaultAsync(q => q.UsuarioId == usuarioId && q.DataIniciado.Date == data);
        }

        public async Task AdicionarQuiz(Quiz quiz)
        {
            _contexto.Quizzes.Add(quiz);
            await _contexto.SaveChangesAsync();
        }
    }
}
