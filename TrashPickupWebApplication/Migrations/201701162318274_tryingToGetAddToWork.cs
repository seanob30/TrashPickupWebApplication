namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingToGetAddToWork : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInfoes", "AccountTypeId", "dbo.AccountTypes");
            DropForeignKey("dbo.UserInfoes", "AddressId", "dbo.Addresses");
            DropIndex("dbo.UserInfoes", new[] { "AccountTypeId" });
            DropIndex("dbo.UserInfoes", new[] { "AddressId" });
            DropColumn("dbo.UserInfoes", "AccountTypeId");
            DropColumn("dbo.UserInfoes", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoes", "AddressId", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoes", "AccountTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserInfoes", "AddressId");
            CreateIndex("dbo.UserInfoes", "AccountTypeId");
            AddForeignKey("dbo.UserInfoes", "AddressId", "dbo.Addresses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.UserInfoes", "AccountTypeId", "dbo.AccountTypes", "ID", cascadeDelete: true);
        }
    }
}
