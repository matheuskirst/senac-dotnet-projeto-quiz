using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;

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
                    Tipo = questao.Tipo,
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

        public async Task<QuestaoExibicao?> ObterTodos()
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
                    Tipo = questao.Tipo,
                    Enunciado = questao.Enunciado,
                    Respondida = false,
                    Pontos = questao.Nivel.Valor,
                    Alternativas = questao.Alternativas.Select(alternativa => new AlternativaExibicao
                    {
                        Id = alternativa.Id,
                        Texto = alternativa.Texto
                    }).ToList()
                })
                .OrderBy(q => EF.Functions.Random())
                .FirstOrDefaultAsync();
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
