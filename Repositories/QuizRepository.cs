using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SenacQuizApp.Global.ModelosConstantes;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Tema)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Nivel)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Tipo)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Alternativas)
            .Include(quiz => quiz.UsuarioRespostas)
                .FirstOrDefaultAsync(quiz => quiz.Id == id);
        }

        public async Task<List<Quiz>> ObterPorUsuarioId(int usuarioId)
        {
            return await _contexto.Quizzes
                .Where(quiz => quiz.UsuarioId == usuarioId)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Tema)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Nivel)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Tipo)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Alternativas)
                .Include(quiz => quiz.UsuarioRespostas)
                .ToListAsync();
        }

        public async Task<Quiz?> ObterPorUsuarioIdEData(int usuarioId, DateOnly data)
        {
            return await _contexto.Quizzes
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Tema)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Nivel)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Tipo)
                .Include(quiz => quiz.Questoes)
                    .ThenInclude(q => q.Alternativas)
                .Include(quiz => quiz.UsuarioRespostas)
                .FirstOrDefaultAsync(quiz => quiz.UsuarioId == usuarioId && quiz.DataExibido == data);
        }
    }
}
