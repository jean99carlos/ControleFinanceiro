using ControleFinanceiro.Application;
using ControleFinanceiro.Application.UseCases.Authentication;
using ControleFinanceiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControleFinanceiro.Controllers
{
    public class AuthenticationController : BaseController
    {

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromServices] IUseCase<LoginInput, LoginOutput> loginUseCase, string Login, string Senha) {
            try
            {
                var response = await loginUseCase.Execute(
                    new LoginInput()
                    {
                        Login = Login,
                        Senha = Senha
                    }
                );
                if (response != null)
                {
                    return Ok(response);
                }
                return Unauthorized();
               
            }
            catch (InvalidLoginException ex) { }
            catch (InvalidPasswordException ex) { }
            catch
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
            return Unauthorized();
        }
    }
}
