using ExampleDDD.Domain.Interfaces.Validators;

namespace ExampleDDD.Domain.Entities.Validators
{
    public class ProdutoValidator : ValidatorBase<Produto>, IProdutoValidator
    {
    }
}
