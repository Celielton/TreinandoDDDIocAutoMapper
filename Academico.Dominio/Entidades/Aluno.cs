using Academico.Dominio.Entidades;
using System;

namespace Academico.Dominio.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int IdCurso { get; set; }
        public DateTime DataMatricula { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
