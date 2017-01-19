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
            context.Days.AddOrUpdate(m => m.ID,
                 new Models.Days { ID = 7, Day = "Sunday" },
                 new Models.Days { ID = 1, Day = "Monday" },
                 new Models.Days { ID = 2, Day = "Tuesday" },
                 new Models.Days { ID = 3, Day = "Wednesday" },
                 new Models.Days { ID = 4, Day = "Thursday" },
                 new Models.Days { ID = 5, Day = "Friday" },
                 new Models.Days { ID = 6, Day = "Saturday" }
                 );
            context.RegularServices.AddOrUpdate(m => m.ID,
                new Models.RegularServices { ID = 1, ServiceName = "Trash Pickup", CostPerPickup = 15 },
                new Models.RegularServices { ID = 2, ServiceName = "Recycling Pickup", CostPerPickup = 20 }
                );
            context.PickupIntervals.AddOrUpdate(m => m.ID,
                new Models.PickupIntervals { ID = 1, Frequency = "Once" },
                new Models.PickupIntervals { ID = 2, Frequency = "Every Day" },
                new Models.PickupIntervals { ID = 3, Frequency = "Once A Week" },
                new Models.PickupIntervals { ID = 4, Frequency = "Twice a month" },
                new Models.PickupIntervals { ID = 5, Frequency = "Once A Month" }
                );
            context.ZipCode.AddOrUpdate(m => m.ID,
                new Models.ZipCode { ID = 4, Zipcodes = 53209 },
                new Models.ZipCode { ID = 5, Zipcodes = 53225 },
                new Models.ZipCode { ID = 6, Zipcodes = 53216 },
                new Models.ZipCode { ID = 7, Zipcodes = 53222 },
                new Models.ZipCode { ID = 8, Zipcodes = 53005 },
                new Models.ZipCode { ID = 9, Zipcodes = 53226 },
                new Models.ZipCode { ID = 10, Zipcodes = 53208 },
                new Models.ZipCode { ID = 11, Zipcodes = 53214 },
                new Models.ZipCode { ID = 12, Zipcodes = 53215 },
                new Models.ZipCode { ID = 13, Zipcodes = 53227 },
                new Models.ZipCode { ID = 14, Zipcodes = 53122 }
                );
            context.State.AddOrUpdate(m => m.ID,
                new Models.State { ID = 2, States = "Illinois" },
                new Models.State { ID = 3, States = "Indiania" },
                new Models.State { ID = 4, States = "Minnesota" },
                new Models.State { ID = 5, States = "Iowa" },
                new Models.State { ID = 6, States = "Ohio" },
                new Models.State { ID = 7, States = "Kansas" },
                new Models.State { ID = 8, States = "Missouri" },
                new Models.State { ID = 9, States = "North Dakota" }
                );
            context.CardType.AddOrUpdate(m => m.ID,
                new Models.CardTypes { ID = 1, CardName = "Visa" },
                new Models.CardTypes { ID = 2, CardName = "Master Card" },
                new Models.CardTypes { ID = 3, CardName = "Discover" },
                new Models.CardTypes { ID = 4, CardName = "American Express" }
                );
        }
    }
}
