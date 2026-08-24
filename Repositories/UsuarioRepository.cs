using SenacQuizApp.Modelos;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;

namespace SenacQuizApp.Repositories
{
    public class UsuarioRepository
    {
        private readonly QuizAppContexto _contexto;
        public UsuarioRepository(QuizAppContexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            _contexto.Usuarios.Update(usuario);
        }

        public async Task<List<Usuario>> ObterTodos()
        {
            return await _contexto.Usuarios
                .OrderBy(u => u.Id)
                .ToListAsync();
        }

        public async Task<Usuario?> ObterPorId(int id)
        {
            return await _contexto.Usuarios
                .FindAsync(id);
        }

        public async Task<Usuario?> ObterPorUsername(string username)
        {
            return await _contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<UsuarioStats?> ObterStatsPorId(int id)
        {
            return await _contexto.UsuarioStats
                .FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
