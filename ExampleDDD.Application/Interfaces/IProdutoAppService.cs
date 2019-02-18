using ExampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace ExampleDDD.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> GetByNome(string nome);
    }
}
