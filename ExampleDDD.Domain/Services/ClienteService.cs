
using System.Collections.Generic;
using System.Linq;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Repositories;
using ExampleDDD.Domain.Interfaces.Services;

namespace ExampleDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial());
        }
    }
}
