using System.Collections.Generic;

namespace Hospital.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Save(T obj);
        void Edit(T obj);
        void Delete(T obj);
        void Dispose();
    }
}