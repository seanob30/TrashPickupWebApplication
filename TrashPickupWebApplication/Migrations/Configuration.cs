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
              //new Models.AccountTypes { ID = 1, AccountType = "Customer" },
              new Models.AccountTypes { ID = 1, AccountType = "Employee" },
              new Models.AccountTypes { ID = 1, AccountType = "Administrator" }
            );
        }
    }
}
