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
    public class AlternativaRepository
    {
        private readonly QuizAppContexto _contexto;
        public AlternativaRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Alternativa?> ObterPorId(int id)
        {
            return await _contexto.Alternativas
                .FindAsync(id);
        }
    }
}
