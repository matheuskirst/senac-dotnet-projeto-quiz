using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Repositories
{
    public class QuizRepository
    {
        private readonly QuizAppContexto _contexto;
        public QuizRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Quiz quiz)
        {
            _contexto.Quizzes.Add(quiz);
        }

        public void Atualizar(Quiz quiz)
        {
            _contexto.Quizzes.Update(quiz);
        }

        public async Task<Quiz?> ObterPorId(int id)
        {
            return await _contexto.Quizzes
                .FindAsync(id);
        }

        public async Task<List<Quiz>> ObterPorUsuarioId(int usuarioId)
        {
            return await _contexto.Quizzes
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .ToListAsync();
        }

        public async Task<List<Quiz>> ObterPorUsuarioIdEData(int usuarioId, DateTime data)
        {
            return await _contexto.Quizzes
                .Where(quiz => quiz.UsuarioId == usuarioId && quiz.DataDeCriacao.Date == data)
                .ToListAsync();
        }
    }
}
