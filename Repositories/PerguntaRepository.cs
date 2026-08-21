using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Modelos;
using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Data;

namespace SenacQuizApp.Repositories
{
    public class PerguntaRepository
    {
        private readonly QuizAppContexto _contexto;
        public PerguntaRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Pergunta pergunta, List<Alternativa> alternativas)
        {
            _contexto.Perguntas.Add(pergunta);
            _contexto.Alternativas.AddRange(alternativas);
        }

        public void AdicionarTema(PerguntaTema tema)
        {
            _contexto.PerguntaTemas.Add(tema);
        }

        public async Task<Pergunta?> ObterPorId(int id)
        {
            return await _contexto.Perguntas
                .FindAsync(id);
        }

        public async Task<List<Pergunta>> ObterAleatorio(int quantidade)
        {
            return await _contexto.Perguntas
                .OrderBy(p => EF.Functions.Random())
                .Take(quantidade)
                .ToListAsync();
        }

        public async Task<List<Pergunta>> ObterAleatorioPorNivel(int quantidade, PerguntaNivel nivel)
        {
            return await _contexto.Perguntas
                .OrderBy(p => EF.Functions.Random())
                .Where(p => p.Nivel == nivel)
                .Take(quantidade)
                .ToListAsync();
        }

        public void SalvarResposta(PerguntaRespondida resposta)
        {
            _contexto.PerguntasRespondidas.Add(resposta);
        }
    }
}
