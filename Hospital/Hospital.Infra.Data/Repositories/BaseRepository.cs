using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Hospital.Domain.Interfaces.Repositories;
using Hospital.Infra.Data.Context;

namespace Hospital.Infra.Data.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        protected HospitalContext Db = new HospitalContext();

        public void Dispose()
        {
            Db.Dispose();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public void Save(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public void Edit(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Delete(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }
    }
}