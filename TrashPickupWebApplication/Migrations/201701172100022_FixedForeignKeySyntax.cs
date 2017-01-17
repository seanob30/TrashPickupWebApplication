namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedForeignKeySyntax : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "ID", "dbo.Cities");
            DropForeignKey("dbo.Addresses", "ID", "dbo.States");
            DropForeignKey("dbo.Addresses", "ID", "dbo.StreetAddresses");
            DropForeignKey("dbo.Addresses", "ID", "dbo.ZipCodes");
            DropForeignKey("dbo.UserInfoes", "ID", "dbo.AccountTypes");
            DropForeignKey("dbo.UserInfoes", "ID", "dbo.Addresses");
            DropIndex("dbo.Addresses", new[] { "ID" });
            DropIndex("dbo.UserInfoes", new[] { "ID" });
            DropPrimaryKey("dbo.Addresses");
            DropPrimaryKey("dbo.UserInfoes");
            AddColumn("dbo.Addresses", "StreetAddressID", c => c.String());
            AddColumn("dbo.Addresses", "CityID", c => c.String());
            AddColumn("dbo.Addresses", "StateID", c => c.String());
            AddColumn("dbo.Addresses", "ZipCodeID", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "City_ID", c => c.Int());
            AddColumn("dbo.Addresses", "State_ID", c => c.Int());
            AddColumn("dbo.Addresses", "StreetAddress_ID", c => c.Int());
            AddColumn("dbo.UserInfoes", "AccountTypeID", c => c.String());
            AddColumn("dbo.UserInfoes", "AddressID", c => c.String());
            AddColumn("dbo.UserInfoes", "AccountType_ID", c => c.Int());
            AddColumn("dbo.UserInfoes", "Address_ID", c => c.Int());
            AlterColumn("dbo.Addresses", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.UserInfoes", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Addresses", "ID");
            AddPrimaryKey("dbo.UserInfoes", "ID");
            CreateIndex("dbo.Addresses", "ZipCodeID");
            CreateIndex("dbo.Addresses", "City_ID");
            CreateIndex("dbo.Addresses", "State_ID");
            CreateIndex("dbo.Addresses", "StreetAddress_ID");
            CreateIndex("dbo.UserInfoes", "AccountType_ID");
            CreateIndex("dbo.UserInfoes", "Address_ID");
            AddForeignKey("dbo.Addresses", "City_ID", "dbo.Cities", "ID");
            AddForeignKey("dbo.Addresses", "State_ID", "dbo.States", "ID");
            AddForeignKey("dbo.Addresses", "StreetAddress_ID", "dbo.StreetAddresses", "ID");
            AddForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.UserInfoes", "AccountType_ID", "dbo.AccountTypes", "ID");
            AddForeignKey("dbo.UserInfoes", "Address_ID", "dbo.Addresses", "ID");
            DropColumn("dbo.Addresses", "StreetAddress");
            DropColumn("dbo.Addresses", "City");
            DropColumn("dbo.Addresses", "State");
            DropColumn("dbo.Addresses", "ZipCode");
            DropColumn("dbo.UserInfoes", "AccountType");
            DropColumn("dbo.UserInfoes", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoes", "Address", c => c.String());
            AddColumn("dbo.UserInfoes", "AccountType", c => c.String());
            AddColumn("dbo.Addresses", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "State", c => c.String());
            AddColumn("dbo.Addresses", "City", c => c.String());
            AddColumn("dbo.Addresses", "StreetAddress", c => c.String());
            DropForeignKey("dbo.UserInfoes", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.UserInfoes", "AccountType_ID", "dbo.AccountTypes");
            DropForeignKey("dbo.Addresses", "ZipCodeID", "dbo.ZipCodes");
            DropForeignKey("dbo.Addresses", "StreetAddress_ID", "dbo.StreetAddresses");
            DropForeignKey("dbo.Addresses", "State_ID", "dbo.States");
            DropForeignKey("dbo.Addresses", "City_ID", "dbo.Cities");
            DropIndex("dbo.UserInfoes", new[] { "Address_ID" });
            DropIndex("dbo.UserInfoes", new[] { "AccountType_ID" });
            DropIndex("dbo.Addresses", new[] { "StreetAddress_ID" });
            DropIndex("dbo.Addresses", new[] { "State_ID" });
            DropIndex("dbo.Addresses", new[] { "City_ID" });
            DropIndex("dbo.Addresses", new[] { "ZipCodeID" });
            DropPrimaryKey("dbo.UserInfoes");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.UserInfoes", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "ID", c => c.Int(nullable: false));
            DropColumn("dbo.UserInfoes", "Address_ID");
            DropColumn("dbo.UserInfoes", "AccountType_ID");
            DropColumn("dbo.UserInfoes", "AddressID");
            DropColumn("dbo.UserInfoes", "AccountTypeID");
            DropColumn("dbo.Addresses", "StreetAddress_ID");
            DropColumn("dbo.Addresses", "State_ID");
            DropColumn("dbo.Addresses", "City_ID");
            DropColumn("dbo.Addresses", "ZipCodeID");
            DropColumn("dbo.Addresses", "StateID");
            DropColumn("dbo.Addresses", "CityID");
            DropColumn("dbo.Addresses", "StreetAddressID");
            AddPrimaryKey("dbo.UserInfoes", "ID");
            AddPrimaryKey("dbo.Addresses", "ID");
            CreateIndex("dbo.UserInfoes", "ID");
            CreateIndex("dbo.Addresses", "ID");
            AddForeignKey("dbo.UserInfoes", "ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.UserInfoes", "ID", "dbo.AccountTypes", "ID");
            AddForeignKey("dbo.Addresses", "ID", "dbo.ZipCodes", "ID");
            AddForeignKey("dbo.Addresses", "ID", "dbo.StreetAddresses", "ID");
            AddForeignKey("dbo.Addresses", "ID", "dbo.States", "ID");
            AddForeignKey("dbo.Addresses", "ID", "dbo.Cities", "ID");
        }
    }
}
