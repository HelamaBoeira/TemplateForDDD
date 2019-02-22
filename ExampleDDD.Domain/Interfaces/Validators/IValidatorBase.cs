using System.Collections.Generic;

namespace ExampleDDD.Domain.Interfaces.Validators
{
    public interface IValidatorBase<TEntity> where TEntity : class
    {
        IList<string> ErrorMessages { get;}
        bool IsValid(TEntity t);
    }
}
