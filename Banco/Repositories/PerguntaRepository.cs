using Microsoft.EntityFrameworkCore;
using SenacQuizApp.banco.config;
using SenacQuizApp.Entidades;
using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Banco.Repositories
{
    public class PerguntaRepository
    {
        private readonly QuizAppContexto _contexto;
        public PerguntaRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task AdicionarPerguntaTema(PerguntaTema tema)
        {
            _contexto.PerguntaTemas.Add(tema);
            await _contexto.SaveChangesAsync();
        }

        public async Task AdicionarPergunta(Pergunta pergunta, List<Alternativa> alternativas)
        {
            _contexto.Perguntas.Add(pergunta);
            _contexto.Alternativas.AddRange(alternativas);
            await _contexto.SaveChangesAsync();
        }

        public async Task SalvarPerguntaRespondida(PerguntaRespondida resposta)
        {
            _contexto.PerguntasRespondidas.Add(resposta);
            await _contexto.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pergunta>> ObterAleatorio(int quantidade, PerguntaNivel? nivel = null)
        {
            IQueryable<Pergunta> query = _contexto.Perguntas;

            if (nivel != null && nivel is PerguntaNivel)
            {
                query = query.Where(p => p.Nivel == nivel);
            }

            var perguntas = await query
                .OrderBy(p => EF.Functions.Random())
                .Take(quantidade)
                .ToListAsync();

            return perguntas;
        }
    }
}
