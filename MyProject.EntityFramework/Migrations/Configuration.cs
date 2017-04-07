using MyProject.Entities;
using System.Data.Entity.Migrations;

namespace MyProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyProject.EntityFramework.MyProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyProject";
        }

        protected override void Seed(MyProject.EntityFramework.MyProjectDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.Persons.AddOrUpdate(
                p => p.Value,
                new Person { Value = "Isaac Asimov" },
                new Person { Value = "Thomas More" },
                new Person { Value = "George Orwell" },
                new Person { Value = "Douglas Adams" }
            );
        }
    }
}
