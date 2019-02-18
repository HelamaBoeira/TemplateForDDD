using ExampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace ExampleDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> GetByNome(string nome);
    }
}
