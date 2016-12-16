using Academico.Aplication.Interfaces;
using Academico.Dominio.Entidades;
using Academico.Dominio.Interfaces.Repositorios;

namespace Academico.Aplication
{
    public class DisciplinaAplication : AplicationBase<Disciplina>, IAplicationDisciplina
    {
        private readonly IDisciplinaRepository _disciplinaRepository;
        public DisciplinaAplication(IDisciplinaRepository disciplinaRepository) : base(disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }
    }
}
