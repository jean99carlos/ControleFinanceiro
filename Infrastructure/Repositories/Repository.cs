using ControleFinanceiro.Domain;
using ControleFinanceiro.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : DbContext, IRepository<TEntity> where TEntity : Entity, new()
    {
        protected DbContext context;
        public Repository(DbContext dbContext)
        {
            context = dbContext;
        }

    }
}
