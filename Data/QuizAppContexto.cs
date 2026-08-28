using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Modelos;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos.Usuarios;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Data
{
    public class QuizAppContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioAcesso> UsuariosAcessos { get; set; }
        public DbSet<UsuarioStats> UsuarioStats { get; set; }
        public DbSet<UsuarioNivel> UsuarioNiveis { get; set; }
        public DbSet<UsuarioResposta> UsuarioRespostas { get; set; }
        public DbSet<UsuarioTemasProgresso> UsuarioTemasProgressos { get; set; }
        public DbSet<UsuarioConquista> UsuarioConquistas { get; set; }
        public DbSet<Questao> Questoes { get; set; }
        public DbSet<QuestaoTema> QuestaoTemas { get; set; }
        public DbSet<QuestaoNivel> QuestaoNiveis { get; set; }
        public DbSet<QuestaoTipo> QuestaoTipos { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<QuizDiario> QuizzesDiarios { get; set; }
        public DbSet<QuizRush> QuizzesRush { get; set; }
        public DbSet<Conquista> Conquistas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=projeto_quiz;Username=postgres;Password=admin;Trust Server Certificate=true");

            optionsBuilder.UseSeeding((context, _) =>
            {
                if (!context.Set<Questao>().Any())
                {
                    var filepath = Path.Combine(AppContext.BaseDirectory, "Data", "Seed", "usuarios.sql");

                    if (File.Exists(filepath))
                    {
                        var sqlContent = File.ReadAllText(filepath);

                        context.Database.ExecuteSqlRaw(sqlContent);
                    }
                }

                if (!context.Set<Questao>().Any())
                {
                    var filepath = Path.Combine(AppContext.BaseDirectory, "Data", "Seed", "questoes.sql");

                    if (File.Exists(filepath))
                    {
                        var sqlContent = File.ReadAllText(filepath);

                        context.Database.ExecuteSqlRaw(sqlContent);
                    }
                }

                if (!context.Set<Conquista>().Any())
                {
                    var filepath = Path.Combine(AppContext.BaseDirectory, "Data", "Seed", "conquistas.sql");

                    if (File.Exists(filepath))
                    {
                        var sqlContent = File.ReadAllText(filepath);

                        context.Database.ExecuteSqlRaw(sqlContent);
                    }
                }
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(u => u.Username)
                    .IsUnique();

                entity.HasOne(u => u.Stats)
                    .WithOne(s => s.Usuario)
                    .HasForeignKey<UsuarioStats>(s => s.UsuarioId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(u => u.DataDeCadastro)
                    .HasColumnType("timestamptz")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(u => u.Username)
                    .HasMaxLength(ModelosConstantes.Usuario.MaxUsernameLength);

                entity.Property(u => u.Nickname)
                    .HasMaxLength(ModelosConstantes.Usuario.MaxNicknameLength);

                entity.Property(u => u.Senha)
                    .HasMaxLength(ModelosConstantes.Usuario.MaxSenhaLength);
            });


            modelBuilder.Entity<UsuarioStats>()
                .HasKey(s => s.UsuarioId);


            modelBuilder.Entity<UsuarioAcesso>(entity =>
            {
                entity.HasKey(uc => new { uc.UsuarioId, uc.DataAcesso });
            });


            modelBuilder.Entity<UsuarioTemasProgresso>(entity =>
            {
                entity.HasKey(uc => new { uc.UsuarioId, uc.TemaId });
            });

            modelBuilder.Entity<UsuarioConquista>(entity =>
            {
                entity.HasKey(uc => new { uc.UsuarioId, uc.ConquistaId });

                entity.Property(uc => uc.DataDeAquisicao)
                    .HasColumnType("timestamptz")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });


            modelBuilder.Entity<UsuarioResposta>(entity =>
            {
                entity.HasKey(ur => new { ur.UsuarioId, ur.QuizId, ur.QuestaoId });
                entity.ToTable("UsuarioRespostas");

                entity.HasOne(ur => ur.Usuario)
                    .WithMany(u => u.Respostas)
                    .HasForeignKey(ur => ur.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ur => ur.Quiz)
                    .WithMany(qz => qz.UsuarioRespostas)
                    .HasForeignKey(ur => ur.QuizId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(ur => ur.Questao)
                    .WithMany(qt => qt.UsuarioRespostas)
                    .HasForeignKey(ur => ur.QuestaoId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(ur => ur.DataDeResposta)
                    .HasColumnType("timestamptz")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });


            modelBuilder.Entity<QuestaoTema>()
                .Property(tm => tm.Nome)
                .HasMaxLength(ModelosConstantes.QuestaoTema.MaxNomeLength);


            modelBuilder.Entity<QuestaoNivel>()
                .Property(n => n.Nome)
                .HasMaxLength(ModelosConstantes.QuestaoNivel.MaxNomeLength);


            modelBuilder.Entity<QuestaoTipo>()
                .Property(tp => tp.Nome)
                .HasMaxLength(ModelosConstantes.QuestaoTipo.MaxNomeLength);


            modelBuilder.Entity<Questao>(entity =>
            {
                entity.HasOne(q => q.Tema)
                    .WithMany(tm => tm.Questoes)
                    .HasForeignKey(q => q.TemaId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(q => q.Nivel)
                    .WithMany(n => n.Questoes)
                    .HasForeignKey(q => q.NivelId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(q => q.Tipo)
                    .WithMany(tp => tp.Questoes)
                    .HasForeignKey(q => q.TipoId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(q => q.Alternativas)
                    .WithOne(a => a.Questao)
                    .HasForeignKey(a => a.QuestaoId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(q => q.Enunciado)
                    .HasMaxLength(ModelosConstantes.Questao.MaxEnunciadoLength);
            });


            modelBuilder.Entity<Alternativa>(entity =>
            {
                entity.HasOne(a => a.Questao)
                    .WithMany(p => p.Alternativas)
                    .HasForeignKey(a => a.QuestaoId);

                entity.Property(a => a.Texto)
                    .HasMaxLength(ModelosConstantes.Alternativa.MaxTextoLength);
            });


            modelBuilder.Entity<QuizDiario>(entity =>
            {
                entity.HasIndex(ud => new { ud.UsuarioId, ud.DataExibido })
                    .IsUnique();

                entity.HasMany(qz => qz.Questoes)
                    .WithMany(qt => qt.Quizzes)
                    .UsingEntity(qq => qq.ToTable("QuizQuestoes"));

                entity.Property(q => q.DataIniciado)
                    .HasColumnType("timestamptz")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(q => q.DataConcluido)
                    .HasColumnType("timestamptz");
            });


            modelBuilder.Entity<Conquista>(entity =>
            {
                entity.Property(uc => uc.Nome)
                    .HasMaxLength(ModelosConstantes.Conquista.MaxNomeLength);

                entity.Property(uc => uc.Descricao)
                    .HasMaxLength(ModelosConstantes.Conquista.MaxDescricaoLength);
            });


        }
    }
}
