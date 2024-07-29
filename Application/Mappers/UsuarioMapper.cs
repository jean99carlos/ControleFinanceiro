using ControleFinanceiro.Application.DTO;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Application.Mappers
{
    public class UsuarioMapper
    {
        public static Usuario CastToDomain(UsuarioDTO dto) {
            return new Usuario() {
                Id = dto.Id,
                Nome = dto.Nome,
                Login = dto.Login
            };
        }
        public static UsuarioDTO CastToDTO(Usuario entity)
        {
            return new UsuarioDTO()
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Login = entity.Login
            };
        }
    }
}
