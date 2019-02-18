
using ExampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace ExampleDDD.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetClientesEspeciais();
    }
}
