using ExampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace ExampleDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {

        IEnumerable<Cliente> GetClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
