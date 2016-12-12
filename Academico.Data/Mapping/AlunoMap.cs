using Academico.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Data.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            HasKey(i => i.Id);

            HasRequired(i => i.Curso).WithMany().HasForeignKey(i => i.IdCurso);
        }
    }
}
