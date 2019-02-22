using ExampleDDD.Domain.Entities.Rules;
using ExampleDDD.Domain.Interfaces.Validators;

namespace ExampleDDD.Domain.Entities.Validators
{
    public class ClienteValidator : ValidatorBase<Cliente>, IClienteValidator
    {
        public ClienteValidator()
        {
            base._rules.Add(new ClienteRegraTeste());
        }

    }
}
