using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SenacQuizApp.Global.ModelosConstantes;

namespace SenacQuizApp.Services
{
    public class ConquistaService
    {
        public event EventHandler<ConquistaDto>? ConquistaDesbloqueada;

        public async Task<List<ConquistaDto>> ObterConquistasUsuario(int usuarioId)
        {
            using var contexto = new QuizAppContexto();

            return await contexto.UsuarioConquistas
                .Where(uc => uc.UsuarioId == usuarioId)
                .Select(uc => new ConquistaDto
                {
                    Nome = uc.Conquista.Nome,
                    Descricao = uc.Conquista.Descricao,
                    DataAquisicao = uc.DataDeAquisicao
                })
                .ToListAsync();
        }

        public async Task ChecarQuizConquistas()
        {
            using var contexto = new QuizAppContexto();
            int usuarioId = UsuarioAtual.Id;

            var conquistas = await contexto.Conquistas
                .Where(c => c.Tipo == ConquistaTipo.PrimeiroQuizTipoDiario ||
                    c.Tipo == ConquistaTipo.AcertosSeguidos ||
                    c.Tipo == ConquistaTipo.MaestriaTema
                    )
                .ToListAsync();

            var primeiroQuizTipoDiario = await contexto.QuizzesDiarios
                .AnyAsync(q => q.UsuarioId == usuarioId && q.Concluido == true);

            var acertosSeguidos = await contexto.QuizzesDiarios
                .AnyAsync(q => q.UsuarioId == usuarioId && q.MaxAcertosSeguidos >= 10);

            var errosSeguidos = await contexto.QuizzesDiarios
                .AnyAsync(q => q.UsuarioId == usuarioId && q.MaxAcertosSeguidos <= 0);

            var progressoTemas = await contexto.UsuarioTemasProgressos
                .Where(t => t.UsuarioId == usuarioId)
                .ToListAsync();

            foreach (var conquista in conquistas)
            {
                switch (conquista.Tipo)
                {
                    case ConquistaTipo.PrimeiroQuizTipoDiario:
                        if (primeiroQuizTipoDiario) await DesbloquearConquista(conquista.Id);
                        break;

                    case ConquistaTipo.AcertosSeguidos:
                        if (conquista.Meta != null && acertosSeguidos == true) await DesbloquearConquista(conquista.Id);
                        break;

                    case ConquistaTipo.MaestriaTema:
                        if (conquista.TemaId != null && conquista.Meta != null)
                        {
                            var progresso = progressoTemas
                                .FirstOrDefault(p => p.TemaId == conquista.TemaId.Value);

                            if (progresso != null && progresso.RespostasCorretas >= conquista.Meta.Value) await DesbloquearConquista(conquista.Id);
                        }
                        break;

                    case ConquistaTipo.ErrosSeguidos:
                        if (conquista.Meta != null && errosSeguidos == true) await DesbloquearConquista(conquista.Id);
                        break;
                }
            }
        }
        
        public async Task ChecarLoginConquistas()
        {
            using var contexto = new QuizAppContexto();
            int usuarioId = UsuarioAtual.Id;

            var conquistas = await contexto.Conquistas
                .Where(c => c.Tipo == ConquistaTipo.AcessosConsecutivos)
                .ToListAsync();

            var acessos = await contexto.Acessos
                .Where(a => a.UsuarioId == usuarioId)
                .OrderByDescending(a => a.DataAcesso)
                .ToListAsync();
        }

        public async Task DesbloquearConquista(ConquistaId conquistaId)
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            bool jaDesbloqueou = await contexto.UsuarioConquistas
                .AnyAsync(uc => uc.UsuarioId == usuarioId && uc.ConquistaId == conquistaId);

            if (jaDesbloqueou) return;

            var usuarioConquista = new UsuarioConquista
            {
                UsuarioId = usuarioId,
                ConquistaId = conquistaId,
                DataDeAquisicao = DateTimeOffset.UtcNow
            };

            contexto.UsuarioConquistas.Add(usuarioConquista);
            await contexto.SaveChangesAsync();

            var conquista = await contexto.Conquistas
                .Where(c => c.Id == conquistaId)
                .Select(c => new ConquistaDto
                {
                    Nome = c.Nome,
                    Descricao = c.Descricao,
                    DataAquisicao = usuarioConquista.DataDeAquisicao
                })
                .FirstOrDefaultAsync();

            if (conquista != null)
            {
                ConquistaDesbloqueada?.Invoke(this, conquista);
            }
        }
    }
}
