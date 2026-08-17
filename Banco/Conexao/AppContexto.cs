using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Entidades;

namespace SenacQuizApp.banco.config
{
    public class AppContexto : DbContext
    {
        // Tabelas
        public DbSet<Conquista> Conquistas { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<PerguntaRespondida> PerguntasRespondidas { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizPergunta> QuizzesPerguntas { get; set; }
        public DbSet<QuizTentativa> QuizzesTentativas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioConquista> UsuarioConquistas { get; set; }

        // Tabelas Lookup
        public DbSet<NivelUsuario> NiveisUsuarios { get; set; }
        public DbSet<NivelPergunta> NiveisPerguntas { get; set; }
        public DbSet<TemaPergunta> TemasPerguntas { get; set; }

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
                        new NivelPergunta { Nome = "Avançado", Pontos = 50 }
                    };

                    context.Set<NivelPergunta>().AddRange(niveisPergunta);
                    context.SaveChanges();
                }

                if (!context.Set<TemaPergunta>().Any())
                {
                    var temasPergunta = new List<TemaPergunta>{
                        new TemaPergunta { Nome = "Hardware" },
                        new TemaPergunta { Nome = "Programação" },
                        new TemaPergunta { Nome = "Redes" },
                        new TemaPergunta { Nome = "Segurança Digital" },
                        new TemaPergunta { Nome = "Sistemas Operacionais" },
                        new TemaPergunta { Nome = "Ferramentas de Produtividade" }
                    };
                    context.Set<TemaPergunta>().AddRange(temasPergunta);
                    context.SaveChanges();
                }

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

            modelBuilder.Entity<Pergunta>()
                .Property(p => p.Tipo)
                .HasConversion<string>();


            modelBuilder.Entity<Alternativa>()
                .HasOne(a => a.Pergunta)
                .WithMany(p => p.Alternativas)
                .HasForeignKey(a => a.PerguntaId);


            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Nickname)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .Property(qt => qt.DataDeCadastro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<Quiz>()
                .Property(q => q.QuantidadePerguntas)
                .HasDefaultValue(10);

            modelBuilder.Entity<Quiz>()
                .Property(q => q.DataDeCriacao)
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


            modelBuilder.Entity<QuizTentativa>()
                .HasKey(qt => new { qt.UsuarioId, qt.QuizId });

            modelBuilder.Entity<QuizTentativa>()
                .HasOne(qt => qt.Usuario)
                .WithMany(u => u.QuizTentativas)
                .HasForeignKey(qt => qt.UsuarioId);

            modelBuilder.Entity<QuizTentativa>()
                .HasOne(qt => qt.Quiz)
                .WithMany(q => q.QuizTentativas)
                .HasForeignKey(qt => qt.QuizId);

            modelBuilder.Entity<QuizTentativa>()
                .Property(qt => qt.DataInicio)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<PerguntaRespondida>()
                .HasKey(pr => new { pr.QuizTentativaId, pr.PerguntaId });

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
