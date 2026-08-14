using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Modelos;

namespace SenacQuizApp.banco.config
{
    public class QuizContexto : DbContext
    {
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Conquista> Conquistas { get; set; }
        public DbSet<UsuarioConquista> UsuarioConquistas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=projeto_quiz;Username=postgres;Password=admin;Trust Server Certificate=true");

            optionsBuilder.UseSeeding((context, _) =>
            {
                if (!context.Set<NivelPergunta>().Any())
                {
                    var niveisPergunta = new List<NivelPergunta>{
                        new NivelPergunta { NivelPerguntaId = 1, Nome = "Iniciante", Pontos = 10 },
                        new NivelPergunta { NivelPerguntaId = 2, Nome = "Fácil", Pontos = 20 },
                        new NivelPergunta { NivelPerguntaId = 3, Nome = "Intermediário", Pontos = 30 },
                        new NivelPergunta { NivelPerguntaId = 4, Nome = "Avançado", Pontos = 40 }
                    };

                    context.Set<NivelPergunta>().AddRange(niveisPergunta);
                    context.SaveChanges();
                }

                if (!context.Set<TemaPergunta>().Any())
                {
                    var temasPergunta = new List<TemaPergunta>{
                        new TemaPergunta { TemaPerguntaId = 1, Nome = "Hardware" },
                        new TemaPergunta { TemaPerguntaId = 2, Nome = "Programação" },
                        new TemaPergunta { TemaPerguntaId = 3, Nome = "Redes" },
                        new TemaPergunta { TemaPerguntaId = 4, Nome = "Segurança Digital" },
                        new TemaPergunta { TemaPerguntaId = 5, Nome = "Sistemas Operacionais" },
                        new TemaPergunta { TemaPerguntaId = 6, Nome = "Ferramentas de Produtividade" }
                    };
                    context.Set<TemaPergunta>().AddRange(temasPergunta);
                    context.SaveChanges();
                }

                if (!context.Set<NivelUsuario>().Any())
                {
                    var niveisUsuario = new List<NivelUsuario>{
                        new NivelUsuario { NivelUsuarioId = 1, Nome = "Iniciante", PontosMin = 0, PontosMax = 500 },
                        new NivelUsuario { NivelUsuarioId = 2, Nome = "Aprendiz", PontosMin = 501, PontosMax = 2000 },
                        new NivelUsuario { NivelUsuarioId = 3, Nome = "Intermediário", PontosMin = 2001, PontosMax = 10000 },
                        new NivelUsuario { NivelUsuarioId = 4, Nome = "Avançado", PontosMin = 10001 }
                    };
                    context.Set<NivelUsuario>().AddRange(niveisUsuario);
                    context.SaveChanges();
                }
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NivelPergunta>();
            modelBuilder.Entity<TemaPergunta>();


            modelBuilder.Entity<Pergunta>()
                .Property(p => p.Tipo)
                .HasConversion<string>();

            modelBuilder.Entity<NivelUsuario>();

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Nickname)
                .IsUnique();

            modelBuilder.Entity<UsuarioConquista>()
                .HasKey(ua => new { ua.UsuarioId, ua.ConquistaId });

            modelBuilder.Entity<UsuarioConquista>()
                .Property(ua => ua.DataDeAquisicao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
