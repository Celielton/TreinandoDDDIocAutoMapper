using System;
using System.Collections.Generic;

namespace Academico.Dominio.Entidades
{
    public class Professor
    {
        public Professor()
        {
            this.Disciplinas = new List<Disciplina>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
