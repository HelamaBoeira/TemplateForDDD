using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Services;
using ExampleDDD.Domain.Interfaces.Validators;
using System.Collections.Generic;


namespace ExampleDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private IClienteValidator _clienteValidator;

        public ClienteAppService(IClienteService clienteService, IClienteValidator clienteValidator)
            :base(clienteService, clienteValidator)
        {
            _clienteService = clienteService;
            _clienteValidator = clienteValidator;
        }

        public IEnumerable<Cliente> GetClientesEspeciais()
        {
            return _clienteService.GetClientesEspeciais(_clienteService.GetAll());
        }
    }
}
