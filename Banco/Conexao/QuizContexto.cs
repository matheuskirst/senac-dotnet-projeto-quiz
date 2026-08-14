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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=projeto_quiz;Username=postgres;Password=admin;Trust Server Certificate=true");

            optionsBuilder.UseSeeding((context, _) =>
            {
                if (!context.Set<NivelPergunta>().Any())
                {
                    var niveisPergunta = new List<NivelPergunta>{
                        new NivelPergunta { Nome = "Iniciante", Pontos = 10 },
                        new NivelPergunta { Nome = "Fácil", Pontos = 20 },
                        new NivelPergunta { Nome = "Intermediário", Pontos = 30 },
                        new NivelPergunta { Nome = "Avançado", Pontos = 40 }
                    };

                    context.Set<NivelPergunta>().AddRange(niveisPergunta);
                    context.SaveChanges();
                }
                
                if (!context.Set<TemaPergunta>().Any())
                {
                    var temasPergunta = new List<TemaPergunta>{
                        new TemaPergunta { Nome = "Hardware" },
                        new TemaPergunta { Nome = "Programação"},
                        new TemaPergunta { Nome = "Redes"},
                        new TemaPergunta { Nome = "Segurança Digital"},
                        new TemaPergunta { Nome = "Sistemas Operacionais"},
                        new TemaPergunta { Nome = "Ferramentas de Produtividade"}
                    };
                    context.Set<TemaPergunta>().AddRange(temasPergunta);
                    context.SaveChanges();
                }
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NivelPergunta>();

            modelBuilder.Entity<Pergunta>()
                .Property(p => p.Tipo)
                .HasConversion<string>();

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Nickname)
                .IsUnique();
        }
    }
}
