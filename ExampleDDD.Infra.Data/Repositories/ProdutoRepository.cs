using System.Collections.Generic;
using System.Linq;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Repositories;

namespace ExampleDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> GetByNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
