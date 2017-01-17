namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetDatabase : DbMigration
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
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cities = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        States = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StreetAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Addresses = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ZipCodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Zipcodes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PickupIntervals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Once = c.Int(nullable: false),
                        EveryDay = c.Int(nullable: false),
                        OnceAWeek = c.Int(nullable: false),
                        EveryOtherWeek = c.Int(nullable: false),
                        OnceAMonth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RegularServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        CostPerPickup = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.ScheduledServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ServiceTypeID = c.String(),
                        ServiceIntervalID = c.String(),
                        ServiceIntervalId_ID = c.Int(),
                        ServiceTypeId_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PickupIntervals", t => t.ServiceIntervalId_ID)
                .ForeignKey("dbo.RegularServices", t => t.ServiceTypeId_ID)
                .Index(t => t.ServiceIntervalId_ID)
                .Index(t => t.ServiceTypeId_ID);
            
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
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserInfoes", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.UserInfoes", "AccountTypeId", "dbo.AccountTypes");
            DropForeignKey("dbo.ScheduledServices", "ServiceTypeId_ID", "dbo.RegularServices");
            DropForeignKey("dbo.ScheduledServices", "ServiceIntervalId_ID", "dbo.PickupIntervals");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Addresses", "ZipCodeId", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "StreetAddressId", "dbo.StreetAddresses");
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.UserInfoes", new[] { "AddressId" });
            DropIndex("dbo.UserInfoes", new[] { "AccountTypeId" });
            DropIndex("dbo.ScheduledServices", new[] { "ServiceTypeId_ID" });
            DropIndex("dbo.ScheduledServices", new[] { "ServiceIntervalId_ID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Addresses", new[] { "ZipCodeId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.Addresses", new[] { "StreetAddressId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UserInfoes");
            DropTable("dbo.ScheduledServices");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RegularServices");
            DropTable("dbo.PickupIntervals");
            DropTable("dbo.Days");
            DropTable("dbo.ZipCodes");
            DropTable("dbo.StreetAddresses");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
            DropTable("dbo.AccountTypes");
        }
    }
}
