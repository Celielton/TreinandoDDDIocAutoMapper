using Academico.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Academico.Data.Mapping
{
    public class CursoMap : EntityTypeConfiguration<Curso>
    {
        public CursoMap()
        {
            HasKey(i => i.Id);

            HasRequired(i => i.Aluno).WithMany().HasForeignKey(i => i.IdAluno);

        }
    }
}
