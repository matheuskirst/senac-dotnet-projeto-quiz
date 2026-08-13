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
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("DB_CONNECTION=Server=localhost;Port=5432;Database=projeto_quiz;Username=postgres;Password=admin;Trust Server Certificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Nickname)
                .IsUnique();
        }
    }
}
