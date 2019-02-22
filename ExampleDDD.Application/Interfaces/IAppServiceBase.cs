using System.Collections.Generic;

namespace ExampleDDD.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        OperationResult Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        OperationResult Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
