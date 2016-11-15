using TrackingTime.Models;

namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrackingTime.DAL.TrackerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TrackingTime.DAL.TrackerContext";
        }

        protected override void Seed(TrackingTime.DAL.TrackerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            var inacap = new Customer { Contact = "Rene León", CustomerId = 1, Email = "rleon@inacap.cl", Name = "Inacap", Status = "Important" };

            context.Customers.AddOrUpdate(inacap);
            context.Projects.AddOrUpdate(
                new Project { Customer = inacap, CustomerId = inacap.CustomerId, Deadline = DateTime.Now, ProjectId = 1, Status = Status.Active, Title = "AMD" },
                new Project { Customer = inacap, CustomerId = inacap.CustomerId, Deadline = DateTime.Now, ProjectId = 2, Status = Status.Active, Title = "Siri" }
            );
        }
    }
}
