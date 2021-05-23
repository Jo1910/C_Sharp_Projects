namespace CodeFirstAPp.Migrations
{
    using CodeFirstAPp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstAPp.Context.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CodeFirstAPp.Context.SchoolContext";
        }

        protected override void Seed(CodeFirstAPp.Context.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Students.AddOrUpdate(
              p => p.StudentID, 
              new Student { StudentID = 1, StFirstName = "Diana", StLastName = "Kirby", Email = "dianakirby@mail.com", SubjectID = 100,},
              new Student { StudentID = 2, StFirstName = "Tom", StLastName = "Jerry", Email = "tomjerry@cat.com", SubjectID = 101},
              new Student { StudentID = 3, StFirstName = "Dwight", StLastName = "Schrute", Email = "dwight@schrutefarms.com", SubjectID = 100}
            );

            context.Subjects.AddOrUpdate(
              s => s.SubjectID,
              new Subject { SubjectID = 100, SubjectName = "Maths", },
              new Subject { SubjectID = 101, SubjectName = "English" }
            );
            //
        }
    }
}
