using System;
using System.Collections.Generic;


namespace Academico.Aplication.Interfaces
{
    public interface IAplicationBase<T> : IDisposable where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
