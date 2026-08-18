using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Entidades;
using SenacQuizApp.Enums;

namespace SenacQuizApp.banco.config
{
    public class QuizAppContexto : DbContext
    {
        // Tabelas
        public DbSet<Conquista> Conquistas { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<PerguntaTema> PerguntaTemas { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<PerguntaRespondida> PerguntasRespondidas { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizPergunta> QuizPerguntas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioConquista> UsuarioConquistas { get; set; }

        // Tabelas Lookup
        public DbSet<NivelUsuario> NiveisUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=projeto_quiz;Username=postgres;Password=admin;Trust Server Certificate=true");

            optionsBuilder.UseSeeding((context, _) =>
            {
                if (!context.Set<NivelUsuario>().Any())
                {
                    var niveisUsuario = new List<NivelUsuario>{
                        new NivelUsuario { Nome = "Iniciante", PontosMin = 0, PontosMax = 500 },
                        new NivelUsuario { Nome = "Aprendiz", PontosMin = 501, PontosMax = 2000 },
                        new NivelUsuario { Nome = "Intermediário", PontosMin = 2001, PontosMax = 10000 },
                        new NivelUsuario { Nome = "Avançado", PontosMin = 10001 }
                    };
                    context.Set<NivelUsuario>().AddRange(niveisUsuario);
                    context.SaveChanges();
                }

                if (!context.Set<Conquista>().Any())
                {
                    var conquistas = new List<Conquista>{
                        new Conquista { Nome = "Primeiro Quiz Concluído", Descricao = "Complete seu primeiro quiz" },
                        new Conquista { Nome = "10 Acertos Seguidos", Descricao = "Atinga 10 respostas corretas em consecução" },
                        new Conquista { Nome = "Mestre em Hardware", Descricao = "Atinga 100 acertos no tema 'Hardware'" },
                        new Conquista { Nome = "Mestre em Programação", Descricao = "Atinga 100 acertos no tema 'Programação'" },
                        new Conquista { Nome = "Mestre em Redes", Descricao = "Atinga 100 acertos no tema 'Redes'" },
                        new Conquista { Nome = "Mestre em Segurança Digital", Descricao = "Atinga 100 acertos no tema 'Segurança Digital'" },
                        new Conquista { Nome = "Mestre em Sistemas Operacionais", Descricao = "Atinga 100 acertos no tema 'Sistemas Operacionais'" },
                        new Conquista { Nome = "Mestre em Ferramentas de Produtividade", Descricao = "Atinga 100 acertos no tema 'Ferramentas de Produtividade'" },
                        new Conquista { Nome = "Acessou por 3 Dias Seguidos", Descricao = "Faça login por três dias consecutivos" },
                        new Conquista { Nome = "Acessou por 7 Dias Seguidos", Descricao = "Faça login a cada dia por uma semana" },
                        new Conquista { Nome = "Acessou por 30 Dias Seguidos", Descricao = "Faça login a cada dia por um mês" },
                        new Conquista { Nome = "Acessou por 90 Dias Seguidos", Descricao = "Faça login a cada dia por três meses consecutivos" },
                        new Conquista { Nome = "Acessou por 365 Dias Seguidos", Descricao = "Faça login a cada dia por um ano" }
                    };
                    context.Set<Conquista>().AddRange(conquistas);
                    context.SaveChanges();
                }
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            modelBuilder.Entity<PerguntaTema>(builder =>
            {
                builder.HasKey(t => t.Id);
                builder.Property(t => t.Id).ValueGeneratedNever();
                builder.Property(t => t.Nome).IsRequired().HasMaxLength(50);

                builder.HasData(PerguntaTema.List());
            });


            modelBuilder.Entity<Pergunta>()
                .HasOne(p => p.Tema)
                .WithMany()
                .HasForeignKey(p => p.TemaId);

            modelBuilder.Entity<Pergunta>()
                .Property(p => p.Tipo)
                .HasConversion<string>();

            modelBuilder.Entity<Pergunta>()
                .Property(p => p.Nivel)
                .HasConversion<string>();


            modelBuilder.Entity<Alternativa>()
                .HasOne(a => a.Pergunta)
                .WithMany(p => p.Alternativas)
                .HasForeignKey(a => a.PerguntaId);


            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .Property(qt => qt.DataDeCadastro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<Quiz>()
                .Property(q => q.DataIniciado)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<QuizPergunta>()
                .HasKey(qp => new { qp.QuizId, qp.PerguntaId });

            modelBuilder.Entity<QuizPergunta>()
                .HasOne(qp => qp.Quiz)
                .WithMany(q => q.QuizPerguntas)
                .HasForeignKey(qp => qp.QuizId);

            modelBuilder.Entity<QuizPergunta>()
                .HasOne(qp => qp.Pergunta)
                .WithMany(p => p.QuizPerguntas)
                .HasForeignKey(qp => qp.PerguntaId);


            modelBuilder.Entity<PerguntaRespondida>()
                .HasKey(pr => new { pr.PerguntaId, pr.QuizId });

            modelBuilder.Entity<PerguntaRespondida>()
                .Property(pr => pr.DataDeResposta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<UsuarioConquista>()
                .HasKey(ua => new { ua.UsuarioId, ua.ConquistaId });

            modelBuilder.Entity<UsuarioConquista>()
                .Property(ua => ua.DataDeAquisicao);
        }
    }
}
