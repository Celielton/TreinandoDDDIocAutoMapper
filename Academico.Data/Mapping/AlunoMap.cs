using Academico.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Data.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            HasKey(i => i.Id);
            Property(i => i.IdCurso).HasColumnName("IdCurso");
            HasRequired(i => i.Curso).WithMany(t => t.Alunos).HasForeignKey(i => i.IdCurso);

        }
    }
}
