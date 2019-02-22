using ExampleDDD.Domain.Interfaces.Validators;
using System.Collections.Generic;

namespace ExampleDDD.Domain.Entities.Validators
{
    public class ValidatorBase<TEntity> : IValidatorBase<TEntity> where TEntity : class
    {
        protected IList<IRule<TEntity>> _rules;
        protected IList<string> _errorMessages;
        IList<string> IValidatorBase<TEntity>.ErrorMessages { get => _errorMessages; }

        public ValidatorBase()
        {
            _rules = new List<IRule<TEntity>>();
            _errorMessages = new List<string>();
        }

        public IList<string> ErrorMessages => new List<string>();

      

        public virtual bool IsValid(TEntity t)
        {
            bool success = true;
            foreach (var rule in _rules)
            {
                if (!rule.IsSatisfy(t))
                {
                    success = false;
                    _errorMessages.Add(rule.ErrorMessage);
                }
            }

            return success;
        }
    }
}
