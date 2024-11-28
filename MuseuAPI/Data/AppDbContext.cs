using Microsoft.EntityFrameworkCore; // Necessário para DbContext e DbSet
using MuseuAPI.Entities; // Adapte o namespace para localizar as entidades do seu projeto

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
            modelBuilder.Entity<Questionario>().Property(q => q.Avaliacao).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Questionario>().Property(q => q.Sugestao).HasMaxLength(500);
            modelBuilder.Entity<Questionario>().Property(q => q.Email).HasMaxLength(100);
        }
    }
}
