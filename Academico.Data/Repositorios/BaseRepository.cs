using Academico.Data.Context;
using Academico.Dominio.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Academico.Data.Repositorios
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AcademicoContext _repository = new AcademicoContext();
        public void Add(T entidade)
        {
            _repository.Set<T>().Add(entidade);
        }


        public IEnumerable<T> GetAll()
        {
            return _repository.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _repository.Set<T>().Find(id);
        }

        public void Remove(T entidade)
        {
            _repository.Set<T>().Remove(entidade);
        }

        public void Update(T entidade)
        {
            _repository.Entry(entidade).State = EntityState.Modified;
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
