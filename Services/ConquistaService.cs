using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Dtos;
using SenacQuizApp.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Services
{
    public class ConquistaService
    {
        public event EventHandler<ConquistaDto>? ConquistaDesbloqueada;

        public async Task ChecarEstadoConquistas()
        {
            using var contexto = new QuizAppContexto();

            int usuarioId = UsuarioAtual.Id;

            UsuarioStats? usuarioStats = await contexto.Usuarios
                .Where(usuario => usuario.Id == usuarioId)
                .Select(usuario => usuario.Stats)
                .FirstOrDefaultAsync();
            
            if (usuarioStats == null) return;

            if (usuarioStats.MaxAcertosConsecutivos >= 10)
            {
                await DesbloquearConquista(ConquistaId.DezAcertosSeguidos);
            }
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

            var conquista = await contexto.Conquistas.FindAsync(conquistaId);
            if (conquista != null)
            {
                var dto = new ConquistaDto(Nome: conquista.Nome, Descricao: conquista.Descricao);
                ConquistaDesbloqueada?.Invoke(this, dto);
            }
        }
    }
}
