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
            //context.AccountType.AddOrUpdate(m => m.ID,
            // new Models.AccountTypes { ID = 1, AccountType = "Customer" },
            // new Models.AccountTypes { ID = 2, AccountType = "Employee" },
            // new Models.AccountTypes { ID = 3, AccountType = "Administrator" }
            //);
            //context.City.AddOrUpdate(m => m.ID,
            //    new Models.City { ID = 1, Cities = "Milwaukee" },
            //    new Models.City { ID = 2, Cities = "Muskego" },
            //    new Models.City { ID = 3, Cities = "Racine"}
            //);
            //context.State.AddOrUpdate(m => m.ID,
            //    new Models.State { ID = 1, States = "Wisconsin" }
            //);
            //context.ZipCode.AddOrUpdate(m => m.ID,
            //    new Models.ZipCode { ID = 1, Zipcodes = 53203 },
            //    new Models.ZipCode { ID = 2, Zipcodes = 53150 },
            //    new Models.ZipCode { ID = 3, Zipcodes = 53406 }
            //);
        }
    }
}
