using SenacQuizApp.banco.config;
using SenacQuizApp.Entidades;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SenacQuizApp.banco.repositories
{
    public class UsuarioRepository
    {
        public static async Task RegistrarUsuario(Usuario usuario)
        {
            using (var db = new AppContexto())
            {
                db.Usuarios.Add(usuario);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<IEnumerable<Usuario>> ObterTodos()
        {
            using (var db = new AppContexto())
            {
                var usuarios = await db.Usuarios
                    .OrderBy(u => u.Id)
                    .ToListAsync();

                return usuarios;
            }
        }

        public static async Task<Usuario?> ObterPorNome(string nome)
        {
            using (var db = new AppContexto())
            {
                var usuario = await db.Usuarios
                    .FirstOrDefaultAsync(u => u.Nome == nome);

                return usuario;
            }
        }
    }
}
