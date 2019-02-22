using ExampleDDD.Domain.Interfaces.Validators;


namespace ExampleDDD.Domain.Entities.Rules
{
    public class ClienteRegraTeste : IRule<Cliente>
    {
        public string ErrorMessage => "Cliente não é valido";

        public bool IsSatisfy(Cliente cliente)
        {
            return cliente.Nome != "NotName";
        }
    }
}
