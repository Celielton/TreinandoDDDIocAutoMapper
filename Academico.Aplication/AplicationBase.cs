using Academico.Aplication.Interfaces;
using Academico.Dominio.Interfaces.Repositorios;
using System.Collections.Generic;


namespace Academico.Aplication
{
    public class AplicationBase<T> : IAplicationBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public AplicationBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
