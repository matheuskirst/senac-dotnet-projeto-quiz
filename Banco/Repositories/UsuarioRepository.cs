using SenacQuizApp.banco.config;
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
        public static async Task CadastrarUsuario(Usuario usuario)
        {
            using (var db = new QuizContexto())
            {
                db.Usuarios.Add(usuario);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<IEnumerable<Usuario>> ObterTodos()
        {
            using (var db = new QuizContexto())
            {
                var usuarios = await db.Usuarios
                    .OrderBy(u => u.UsuarioId)
                    .ToListAsync();

                return usuarios;
            }
        }

        public static async Task<IEnumerable<Usuario>> ObterUsuarioPorNick(string nickname)
        {
            using (var db = new QuizContexto())
            {
                var usuarios = await db.Usuarios
                    .Where(u => u.Nickname == nickname)
                    .OrderBy(u => u.UsuarioId)
                    .ToListAsync();

                return usuarios;
            }
        }
    }
}
