using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Services
{
    public class QuestaoService
    {
        public async Task<QuestaoExibicao?> ObterAleatorio()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.Questoes
                .Select(questao => new QuestaoExibicao
                {
                    Id = questao.Id,
                    TemaId = questao.TemaId,
                    Tema = questao.Tema.Nome,
                    NivelId = questao.NivelId,
                    Nivel = questao.Nivel.Nome,
                    Tipo = questao.Tipo.Nome,
                    Enunciado = questao.Enunciado,
                    Respondida = false,
                    Pontos = questao.Nivel.Valor,
                    Alternativas = questao.Alternativas.Select(alternativa => new AlternativaExibicao
                    {
                        Id = alternativa.Id,
                        Texto = alternativa.Texto
                    })
                    .OrderBy(q => EF.Functions.Random())
                    .ToList()
                })
                .OrderBy(q => EF.Functions.Random())
                .FirstOrDefaultAsync();
        }

        public async Task<List<QuestaoDados>?> ObterTodos(string? enunciado=null, QuestaoTipoId? tipo=null, QuestaoNivelId? nivel=null, int? tema=null)
        {
            using var contexto = new QuizAppContexto();

            IQueryable<Questao> query = contexto.Questoes;

            if (!string.IsNullOrWhiteSpace(enunciado))
            {
                query = query.Where(q => q.Enunciado.ToLower().Contains(enunciado.ToLower()));
            }

            if (tipo != null && tipo is QuestaoTipoId)
            {
                query = query.Where(q => q.TipoId == tipo);
            }

            if (nivel != null && nivel is QuestaoNivelId)
            {
                query = query.Where(q => q.NivelId == nivel);
            }

            if (tema != null && tema is int)
            {
                query = query.Where(q => q.TemaId == tema);
            }

            return await query
                .Select(q => new QuestaoDados
                {
                    Id = q.Id,

                    TipoId = q.TipoId,
                    Tipo = q.Tipo.Nome,

                    NivelId = q.NivelId,
                    Nivel = q.Nivel.Nome,

                    TemaId = q.TemaId,
                    Tema = q.Tema.Nome,

                    Enunciado = q.Enunciado,
                    Pontos = q.Nivel.Valor,

                    Alternativas = q.Alternativas.Select(a => new AlternativaResposta
                    {
                        Id = a.Id,
                        Texto = a.Texto,
                        Correta = a.EhCorreta
                    }).ToList(),

                    VerdadeiroFalso = q.VerdadeiroFalso
                })
                .ToListAsync();
        }

        public async Task<List<QuestaoTemas>> ObterQuestaoTemas()
        {
            using var contexto = new QuizAppContexto();

            return await contexto.QuestaoTemas
                .Select(tema => new QuestaoTemas
                {
                    Id = tema.Id,
                    Nome = tema.Nome
                })
                .ToListAsync();
        }
    }
}
