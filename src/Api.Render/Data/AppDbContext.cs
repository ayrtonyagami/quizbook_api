using Api.Render.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Api.Render.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Opcao> Opcoes { get; set; }
    }
}
