using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace ControleFinanceiro.Infrastructure
{
    public class ControleFinanceiroDbContext : DbContext
    {
        public ControleFinanceiroDbContext(DbContextOptions<ControleFinanceiroDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .Property(x => x.SenhaHash).HasColumnName("senha_hash");
        }
    }
}