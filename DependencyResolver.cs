using ControleFinanceiro.Application;
using ControleFinanceiro.Application.UseCases.Authentication;
using ControleFinanceiro.Common.Helpers;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infrastructure.Interfaces;
using ControleFinanceiro.Infrastructure.Repositories;

namespace ControleFinanceiro
{
    public static class DependencyResolver
    {
        public static void Register(IServiceCollection services) {
            RegisterHelpers(services);
            RegisterApplicationServices(services);
            RegisterDomainServices(services);
            RegisterRepositories(services);
        }
        public static void RegisterApplicationServices(IServiceCollection services)
        {
            services.AddTransient<IUseCase<LoginInput, LoginOutput>, LoginUseCase>();
        }
        public static void RegisterHelpers(IServiceCollection services)
        {
            services.AddScoped<IPasswordHasher, PasswordHasher>();
        }
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
        public static void RegisterDomainServices(IServiceCollection services)
        {

        }      
        
    }
}
