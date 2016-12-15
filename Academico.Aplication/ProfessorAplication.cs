using Academico.Aplication.Interfaces;
using Academico.Dominio.Entidades;
using Academico.Dominio.Interfaces.Repositorios;

namespace Academico.Aplication
{
    public class ProfessorAplication : AplicationBase<Professor>, IAplicationProfessor
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorAplication(IProfessorRepository professorRespository) : base(professorRespository)
        {
            _professorRepository = professorRespository;
        }
    }
}
