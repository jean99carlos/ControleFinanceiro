using ControleFinanceiro.Application.Mappers;
using ControleFinanceiro.Common.Helpers;
using ControleFinanceiro.Infrastructure.Interfaces;

namespace ControleFinanceiro.Application.UseCases.Authentication
{
    public class LoginUseCase : IUseCase<LoginInput, LoginOutput>
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginUseCase(IUsuarioRepository usuarioRepository, IPasswordHasher passwordHasher)
        {
            _usuarioRepository = usuarioRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<LoginOutput> Execute(LoginInput input)
        {
            var usuario = await _usuarioRepository.GetByLogin(input.Login);

            if (usuario == null)
            {
                throw new InvalidLoginException();
            }
            bool isPasswordValid = _passwordHasher.VerifyPassword(input.Senha, usuario.Salt, usuario.SenhaHash);

            if (!isPasswordValid)
            {
                throw new InvalidPasswordException();
            }

            var usuarioDTO = UsuarioMapper.CastToDTO(usuario);

            return new LoginOutput { Usuario = usuarioDTO};
        }
    }
}
