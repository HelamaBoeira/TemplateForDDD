
using System.Collections.Generic;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Repositories;
using ExampleDDD.Domain.Interfaces.Services;

namespace ExampleDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository  _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetByNome(string nome)
        {
            return _produtoRepository.GetByNome(nome);
        }
    }
}
