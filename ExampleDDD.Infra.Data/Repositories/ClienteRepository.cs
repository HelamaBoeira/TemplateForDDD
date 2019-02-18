using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.Repositories;

namespace ExampleDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
