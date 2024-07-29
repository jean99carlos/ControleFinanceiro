using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Infrastructure.Interfaces
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        public Task<Usuario> GetByLogin(string Login);

    }
}
