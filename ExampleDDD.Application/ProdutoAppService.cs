using System.Collections.Generic;
using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Services;
using ExampleDDD.Domain.Interfaces.Validators;

namespace ExampleDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService, IProdutoValidator produtoValidator)
            :base(produtoService, produtoValidator)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> GetByNome(string nome)
        {
            return _produtoService.GetByNome(nome);
        }
    }
}
