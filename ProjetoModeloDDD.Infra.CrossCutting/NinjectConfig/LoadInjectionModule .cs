using ExampleDDD.Application;
using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Interfaces.Repositories;
using ExampleDDD.Domain.Interfaces.Services;
using ExampleDDD.Domain.Services;
using ExampleDDD.Infra.Data.Repositories;
using Ninject.Modules;

namespace ProjetoModeloDDD.Infra.CrossCutting.NinjectConfig
{
    public class LoadInjectionModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IProdutoService>().To<ProdutoService>();

            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
        }
    }
}
