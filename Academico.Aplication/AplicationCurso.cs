using Academico.Aplication.Interfaces;
using Academico.Dominio.Entidades;
using Academico.Dominio.Interfaces.Repositorios;

namespace Academico.Aplication
{
    public class AplicationCurso : AplicationBase<Curso>, IAplicationCurso
    {
        private readonly ICursoRepository _cursoRepository;
        public AplicationCurso(ICursoRepository cursoRespository) : base(cursoRespository)
        {
            _cursoRepository = cursoRespository;
        }
    }
}
