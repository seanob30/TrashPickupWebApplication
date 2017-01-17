namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedChangeMyInfoView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "StreetAddress", c => c.String());
            AddColumn("dbo.Addresses", "City", c => c.String());
            AddColumn("dbo.Addresses", "State", c => c.String());
            AddColumn("dbo.Addresses", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoes", "AccountType", c => c.String());
            AddColumn("dbo.UserInfoes", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "Address");
            DropColumn("dbo.UserInfoes", "AccountType");
            DropColumn("dbo.Addresses", "ZipCode");
            DropColumn("dbo.Addresses", "State");
            DropColumn("dbo.Addresses", "City");
            DropColumn("dbo.Addresses", "StreetAddress");
        }
    }
}
