using Academico.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Data.Mapping
{
    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMap()
        {
            HasKey(i => i.Id);

            HasRequired(i => i.Curso)
                .WithMany()
                .HasForeignKey(I => I.IdCurso);

            HasRequired(i => i.Professor)
                .WithMany()
                .HasForeignKey(i => i.IdProfessor);
        }
    }
}
