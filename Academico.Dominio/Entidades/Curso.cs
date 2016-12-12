using System;
using System.Collections.Generic;

namespace Academico.Dominio.Entidades
{
    public class Curso
    {
       

        public Curso()
        {
            this.Disciplinas = new List<Disciplina>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }
        public int IdAluno { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
