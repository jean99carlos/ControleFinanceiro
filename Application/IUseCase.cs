namespace ControleFinanceiro.Application
{
    public interface IUseCase<Input, Output> where Input : class where Output : class
    {
        public Task<Output> Execute(Input input);
    }
}
