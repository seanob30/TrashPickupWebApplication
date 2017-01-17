namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrashPickupWebApplication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashPickupWebApplication.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.AccountType.AddOrUpdate(m => m.ID,
              new Models.AccountTypes { ID = 1, AccountType = "Customer" },
              new Models.AccountTypes { ID = 2, AccountType = "Employee" },
              new Models.AccountTypes { ID = 3, AccountType = "Administrator" }
              );
           context.Days.AddOrUpdate(m =>m.ID,
              new Models.Days {  ID = 1 , Day = "Sunday"},
              new Models.Days { ID = 2, Day = "Monday" },
              new Models.Days { ID = 3, Day = "Tuesday" },
              new Models.Days { ID = 4, Day = "Wednesday" },
              new Models.Days { ID = 5, Day = "Thursday" },
              new Models.Days { ID = 6, Day = "Friday" },
              new Models.Days { ID = 7, Day = "Saturday" }
            );
        }
    }
}
