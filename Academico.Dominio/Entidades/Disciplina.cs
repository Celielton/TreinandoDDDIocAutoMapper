using System;

namespace Academico.Dominio.Entidades
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdCurso { get; set; }
        public virtual Curso Curso { get; set; }
        public int IdProfessor { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
