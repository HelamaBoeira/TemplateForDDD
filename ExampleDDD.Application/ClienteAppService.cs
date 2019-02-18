using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace ExampleDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            :base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> GetClientesEspeciais()
        {
            return _clienteService.GetClientesEspeciais(_clienteService.GetAll());
        }
    }
}
