using Microsoft.EntityFrameworkCore;
using MuseuAPI.Entities;

namespace MuseuAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Obra> Obras { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da tabela Obras
            modelBuilder.Entity<Obra>().ToTable("Obras");
            modelBuilder.Entity<Obra>().HasKey(o => o.Id);
            modelBuilder.Entity<Obra>().Property(o => o.Nome).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Obra>().Property(o => o.Descricao).HasMaxLength(500);

            // Configuração da tabela Questionarios
            modelBuilder.Entity<Questionario>().ToTable("Questionarios");
            modelBuilder.Entity<Questionario>().HasKey(q => q.Id);
            
            modelBuilder.Entity<Questionario>().Property(q => q.Email).HasMaxLength(100);
            modelBuilder.Entity<Questionario>().Property(q => q.DataNascimento).IsRequired();

            modelBuilder.Entity<Questionario>().Property(q => q.Pergunta1).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Questionario>().Property(q => q.Resposta1).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Questionario>().Property(q => q.Pergunta2).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Questionario>().Property(q => q.Resposta2).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Questionario>().Property(q => q.Pergunta3).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Questionario>().Property(q => q.Resposta3).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Questionario>().Property(q => q.Pergunta4).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Questionario>().Property(q => q.Resposta4).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Questionario>().Property(q => q.Pergunta5).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Questionario>().Property(q => q.Resposta5).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Questionario>().Property(q => q.Comentarios).HasMaxLength(1000);
        }
    }
}
