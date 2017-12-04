using System;
using System.Collections.Generic;
using Hospital.Domain.Interfaces.Repositories;
using Hospital.Domain.Interfaces.Services;

namespace Hospital.Domain.Services
{
    public class BaseService<T> : IDisposable, IBaseServices<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            this._repository = repository;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return GetAll();
        }

        public void Save(T obj)
        {
            _repository.Save(obj);
        }

        public void Edit(T obj)
        {
            _repository.Edit(obj);
        }

        public void Delete(T obj)
        {
            _repository.Delete(obj);
        }
    }
}