namespace Academico.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Academico.Data.Context.AcademicoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Academico.Data.Context.AcademicoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            //var curso = context.Curso.Add(new Dominio.Entidades.Curso { Nome = "Análise de Sistemas", DataCadastro = DateTime.Now });
            //var professor = context.Professor.Add(new Dominio.Entidades.Professor { Nome = "Charles Fung", DataAdmissao = DateTime.Now });

            //context.SaveChanges();

            //context.Discliplina.AddOrUpdate(new Dominio.Entidades.Disciplina { IdCurso = curso.Id, DataCadastro = DateTime.Now, Nome = "Linguagem de Programação", IdProfessor = professor.Id });

            //context.Aluno.AddOrUpdate(new Dominio.Entidades.Aluno { Nome = "Elton", DataMatricula = DateTime.Now, Email = "ramalho@bne.com.br", IdCurso = curso.Id });

            //context.SaveChanges();
        }
    }
}
