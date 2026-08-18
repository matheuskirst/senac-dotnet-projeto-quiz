using SenacQuizApp.banco.config;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Entidades;

namespace SenacQuizApp.banco.repositories
{
    public class UsuarioRepository
    {
        private readonly QuizAppContexto _contexto;
        public UsuarioRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task RegistrarUsuario(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            await _contexto.SaveChangesAsync();
        }

        public async Task<Usuario?> ObterPorNome(string nome)
        {
            return await _contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Username == nome);
        }

        public async Task<IEnumerable<Usuario>> ObterTodos()
        {
            return await _contexto.Usuarios
                .OrderBy(u => u.Id)
                .ToListAsync();
        }
    }
}
