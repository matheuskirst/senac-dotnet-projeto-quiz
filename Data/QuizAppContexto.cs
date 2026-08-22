using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Modelos;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Data
{
    public class QuizAppContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioStatus> UsuariosStatus { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<PerguntaTema> PerguntaTemas { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<UsuarioResposta> UsuariosRespostas { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Conquista> Conquistas { get; set; }
        public DbSet<UsuarioConquista> UsuarioConquistas { get; set; }

        protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=projeto_quiz;Username=postgres;Password=admin;Trust Server Certificate=true");

            optionsBuilder.UseSeeding((context, _) =>
            {
                if (!context.Set<Pergunta>().Any())
                {
                    var filepath = Path.Combine(AppContext.BaseDirectory, "perguntas.sql");

                    if (File.Exists(filepath))
                    {
                        var sqlContent = File.ReadAllText(filepath);

                        context.Database.ExecuteSqlRaw(sqlContent);
                    }
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

            modelBuilder.Entity<PerguntaTema>(entity =>
            {
                entity.HasKey(pt => pt.Id);

                entity.Property(pt => pt.Nome)
                    .HasMaxLength(200);
            });


            modelBuilder.Entity<Pergunta>()
                .HasMany(p => p.Alternativas)
                .WithOne(a => a.Pergunta)
                .HasForeignKey(a => a.PerguntaId)
                .OnDelete(DeleteBehavior.Cascade);

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
                .Property(u => u.DataDeCadastro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<UsuarioStatus>()
                .Property(u => u.Nivel)
                .HasConversion<string>();


            modelBuilder.Entity<UsuarioResposta>()
                .HasKey(pr => new { pr.QuizId, pr.PerguntaId });

            modelBuilder.Entity<UsuarioResposta>()
                .Property(pr => pr.DataDeResposta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<UsuarioConquista>()
                .HasKey(uc => new { uc.UsuarioId, uc.ConquistaId });

            modelBuilder.Entity<UsuarioConquista>()
                .Property(uc => uc.DataDeAquisicao);


            modelBuilder.Entity<Quiz>()
                .HasIndex(ud => new { ud.UsuarioId, ud.DataExibido })
                .IsUnique();

            modelBuilder.Entity<Quiz>()
                .Property(pr => pr.DataExibido)
                .HasDefaultValueSql("CURRENT_DATE");

            modelBuilder.Entity<Quiz>()
                .HasMany(q => q.Perguntas)
                .WithMany(p => p.Quizzes)
                .UsingEntity(qp => qp.ToTable("QuizPerguntas"));

            modelBuilder.Entity<Quiz>()
                .Property(q => q.DataInicio)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
