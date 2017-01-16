namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class willProbablyBreak : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "AccountTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoes", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserInfoes", "AccountTypeId");
            CreateIndex("dbo.UserInfoes", "AddressId");
            AddForeignKey("dbo.UserInfoes", "AccountTypeId", "dbo.AccountTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.UserInfoes", "AddressId", "dbo.Addresses", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.UserInfoes", "AccountTypeId", "dbo.AccountTypes");
            DropIndex("dbo.UserInfoes", new[] { "AddressId" });
            DropIndex("dbo.UserInfoes", new[] { "AccountTypeId" });
            DropColumn("dbo.UserInfoes", "AddressId");
            DropColumn("dbo.UserInfoes", "AccountTypeId");
        }
    }
}
