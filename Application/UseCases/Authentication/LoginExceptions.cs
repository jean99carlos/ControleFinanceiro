namespace ControleFinanceiro.Application.UseCases.Authentication
{
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException() : base("Login inválido") { }

        public InvalidLoginException(string message) : base(message) { }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Senha inválida") { }

        public InvalidPasswordException(string message) : base(message) { }
    }
}
