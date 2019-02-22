using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Interfaces.Services;
using ExampleDDD.Domain.Interfaces.Validators;
using System;
using System.Collections.Generic;

namespace ExampleDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private IValidatorBase<TEntity> _validatorBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase, IValidatorBase<TEntity> validator)
        {
            _serviceBase = serviceBase;
            _validatorBase = validator;
        }

        public OperationResult Add(TEntity obj)
        {
            var result = new OperationResult();

            if (_validatorBase.IsValid(obj))
                _serviceBase.Add(obj);
            else
            {
                result.Success = false;
                result.ErrorsMessage = _validatorBase.ErrorMessages;
            }
            return result;

        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public OperationResult Update(TEntity obj)
        {
            var result = new OperationResult();

            if (_validatorBase.IsValid(obj))
                _serviceBase.Update(obj);
            else
            {
                result.Success = false;
                result.ErrorsMessage = _validatorBase.ErrorMessages;
            }
            return result;
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }


    }
}
