namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somethingMightBeWrong : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AddressViewModels", "CityID", "dbo.Cities");
            DropForeignKey("dbo.AddressViewModels", "StateID", "dbo.States");
            DropForeignKey("dbo.AddressViewModels", "StreetAddressID", "dbo.StreetAddresses");
            DropForeignKey("dbo.AddressViewModels", "ZipCodeID", "dbo.ZipCodes");
            DropIndex("dbo.AddressViewModels", new[] { "StreetAddressID" });
            DropIndex("dbo.AddressViewModels", new[] { "CityID" });
            DropIndex("dbo.AddressViewModels", new[] { "StateID" });
            DropIndex("dbo.AddressViewModels", new[] { "ZipCodeID" });
            DropTable("dbo.AddressViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AddressViewModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StreetAddressID = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        StateID = c.Int(nullable: false),
                        ZipCodeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.AddressViewModels", "ZipCodeID");
            CreateIndex("dbo.AddressViewModels", "StateID");
            CreateIndex("dbo.AddressViewModels", "CityID");
            CreateIndex("dbo.AddressViewModels", "StreetAddressID");
            AddForeignKey("dbo.AddressViewModels", "ZipCodeID", "dbo.ZipCodes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.AddressViewModels", "StreetAddressID", "dbo.StreetAddresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.AddressViewModels", "StateID", "dbo.States", "ID", cascadeDelete: true);
            AddForeignKey("dbo.AddressViewModels", "CityID", "dbo.Cities", "ID", cascadeDelete: true);
        }
    }
}
