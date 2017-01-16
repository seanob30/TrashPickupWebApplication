namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInfoAddressAndContextAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StreetAddressId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        ZipCodeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .ForeignKey("dbo.StreetAddresses", t => t.StreetAddressId, cascadeDelete: true)
                .ForeignKey("dbo.ZipCodes", t => t.ZipCodeId, cascadeDelete: true)
                .Index(t => t.StreetAddressId)
                .Index(t => t.CityId)
                .Index(t => t.StateId)
                .Index(t => t.ZipCodeId);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SignUpDate = c.String(),
                        AccountTypeId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AccountTypeId)
                .Index(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.UserInfoes", "AccountTypeId", "dbo.AccountTypes");
            DropForeignKey("dbo.Addresses", "ZipCodeId", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "StreetAddressId", "dbo.StreetAddresses");
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.UserInfoes", new[] { "AddressId" });
            DropIndex("dbo.UserInfoes", new[] { "AccountTypeId" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.Addresses", new[] { "StreetAddressId" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Addresses");
            DropTable("dbo.AccountTypes");
        }
    }
}
