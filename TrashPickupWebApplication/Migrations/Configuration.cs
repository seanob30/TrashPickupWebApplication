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
            context.Days.AddOrUpdate(m => m.ID,
               new Models.Days { ID = 1, Day = "Sunday" },
               new Models.Days { ID = 2, Day = "Monday" },
               new Models.Days { ID = 3, Day = "Tuesday" },
               new Models.Days { ID = 4, Day = "Wednesday" },
               new Models.Days { ID = 5, Day = "Thursday" },
               new Models.Days { ID = 6, Day = "Friday" },
               new Models.Days { ID = 7, Day = "Saturday" }
             );
            string line;
            int idCounter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\SeedData\free-zipcode-database-Primary (1).txt");
            while ((line = file.ReadLine()) != null)
            {
                idCounter++;
                context.ZipCode.AddOrUpdate(m => m.ID,
                    new Models.ZipCode { ID = idCounter, Zipcodes = Int32.Parse(line) }
                );
            }
            context.RegularServices.AddOrUpdate(m => m.ID,
              new Models.RegularServices { ID = 1, ServiceName = "Trash Pickup", CostPerPickup = 15 },
              new Models.RegularServices { ID = 1, ServiceName = "Recycling Pickup", CostPerPickup = 20 }
              );
            context.PickupIntervals.AddOrUpdate(m => m.ID,
                new Models.PickupIntervals { ID = 1, Frequency = "Once" },
                new Models.PickupIntervals { ID = 1, Frequency = "Every Day" },
                new Models.PickupIntervals { ID = 1, Frequency = "Once A Week" },
                new Models.PickupIntervals { ID = 1, Frequency = "Twice a month" },
                new Models.PickupIntervals { ID = 1, Frequency = "Once A Month" }
                );
            idCounter = 0;
            System.IO.StreamReader files = new System.IO.StreamReader(@"..\..\SeedData\wisconsinCities.txt");
            while ((line = files.ReadLine()) != null)
            {
                idCounter++;
                context.City.AddOrUpdate(m => m.ID,
                    new Models.City { ID = idCounter, Cities = line }
                );
            }
            idCounter = 0;
            System.IO.StreamReader filed = new System.IO.StreamReader(@"..\..\SeedData\states.txt");
            while ((line = filed.ReadLine()) != null)
            {
                idCounter++;
                context.State.AddOrUpdate(m => m.ID,
                    new Models.State { ID = idCounter, States = line }
                );
            }
        }
    }
}
