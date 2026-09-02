using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    }).ToList()
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
    }
}
