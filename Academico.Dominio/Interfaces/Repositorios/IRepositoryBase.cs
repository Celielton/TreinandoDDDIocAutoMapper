using System;
using System.Collections.Generic;

namespace Academico.Dominio.Interfaces.Repositorios
{
    public interface IRepositoryBase<T> : IDisposable  where T : class
    {
        void Add(T entidade);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entidade);
        void Remove(T entidade);
    }
}
