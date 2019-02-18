using ExampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace ExampleDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {

        IEnumerable<Produto> GetByNome(string nome);
    }
}
