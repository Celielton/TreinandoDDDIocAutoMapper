using Academico.Aplication.Interfaces;
using Academico.Dominio.Entidades;
using Academico.Dominio.Interfaces.Repositorios;

namespace Academico.Aplication
{
    public class AlunoAplication : AplicationBase<Aluno>, IAplicationAluno
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoAplication(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
            _alunoRepository = alunoRepository; 
        }
    }
}
