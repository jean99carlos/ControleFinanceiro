namespace ControleFinanceiro.Domain.Entities
{
    public class Usuario: Entity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string SenhaHash { get; set; }
        public string Salt { get; set; }
    }
}
