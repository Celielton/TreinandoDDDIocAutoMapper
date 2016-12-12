using Academico.Data.Mapping;
using Academico.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Academico.Data.Context
{
    public class AcademicoContext : DbContext
    {
        public AcademicoContext()
            : base("CONN")
        {
            
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Discliplina { get; set; }
        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new ProfessorMap());
            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new CursoMap());


            base.OnModelCreating(modelBuilder);
        }

    }
}

