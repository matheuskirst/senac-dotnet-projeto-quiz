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
    public class QuestaoRepository
    {
        private readonly QuizAppContexto _contexto;
        public QuestaoRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Questao pergunta, List<Alternativa> alternativas)
        {
            _contexto.Questoes.Add(pergunta);
            _contexto.Alternativas.AddRange(alternativas);
        }

        public void AdicionarTema(QuestaoTema tema)
        {
            _contexto.QuestaoTemas.Add(tema);
        }

        public async Task<Questao?> ObterPorId(int id)
        {
            return await _contexto.Questoes
                .FindAsync(id);
        }

        public async Task<List<Questao>> ObterQuestoesParaQuiz()
        {
            var questaoAvancada = _contexto.Questoes
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .Where(q => q.NivelId == QuestaoNivelId.Avancado)
                .OrderBy(q => Guid.NewGuid())
                .Take(1)
                .FirstOrDefault();

            var questoes = questaoAvancada != null ? new List<Questao> {questaoAvancada} : new List<Questao>();

            int? idAvancada = questaoAvancada?.Id;

            var questoesAleatorias = await _contexto.Questoes
                .Include(q => q.Tema)
                .Include(q => q.Nivel)
                .Include(q => q.Tipo)
                .Include(q => q.Alternativas)
                .Where(q => q.Id != idAvancada)
                .OrderBy(q => Guid.NewGuid())
                .Take(9)
                .ToListAsync();

            questoes.AddRange(questoesAleatorias);

            return questoes;
        }

        public async Task<bool> VerificarAlternativa(int? alternativaId)
        {
            return await _contexto.Alternativas
                .Where(a => a.Id == alternativaId)
                .Select(a => a.IsCorreta)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> VerificarVerdadeiroFalso(int questaoId, bool? resposta)
        {
            return await _contexto.Questoes
                .Where(q => q.Id == questaoId)
                .Select(q => q.Verdadeira == resposta)
                .FirstOrDefaultAsync();
        }

        public void AdicionarResposta(UsuarioResposta resposta)
        {
            _contexto.UsuarioRespostas.Add(resposta);
        }
    }
}
