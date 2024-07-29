using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly ControleFinanceiroDbContext _dbContext;
        public UsuarioRepository(ControleFinanceiroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario?> GetByLogin(string login) {
            return await _dbContext.Set<Usuario>()
                .AsNoTracking()
                .FirstOrDefaultAsync(usuario => usuario.Login == login);
        }
    }
}
