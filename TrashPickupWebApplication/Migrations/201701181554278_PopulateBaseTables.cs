namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBaseTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccountTypes (AccountType) VALUES ('Customer')");
            Sql("INSERT INTO AccountTypes (AccountType) VALUES ('Employee')");
            Sql("INSERT INTO AccountTypes (AccountType) VALUES ('Administrator')");

            Sql("INSERT INTO Cities (Cities) VALUES ('Milwaukee')");
            Sql("INSERT INTO Cities (Cities) VALUES ('Muskego')");
            Sql("INSERT INTO Cities (Cities) VALUES ('Racine')");

            Sql("INSERT INTO States (States) VALUES ('Wisconsin')");

            Sql("INSERT INTO ZipCodes (Zipcodes) VALUES ('53203')");
            Sql("INSERT INTO ZipCodes (Zipcodes) VALUES ('53150')");
            Sql("INSERT INTO ZipCodes (Zipcodes) VALUES ('53406')");
        }
        
        public override void Down()
        {
        }
    }
}
