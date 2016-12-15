using System;
using System.Collections.Generic;

namespace Academico.Dominio.Entidades
{
    public class Curso
    {
       

        public Curso()
        {
            this.Disciplinas = new List<Disciplina>();
            this.Alunos = new List<Aluno>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
