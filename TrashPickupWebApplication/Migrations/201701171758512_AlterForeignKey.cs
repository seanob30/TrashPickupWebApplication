namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "StreetAddress", c => c.String());
            AddColumn("dbo.Addresses", "City", c => c.String());
            AddColumn("dbo.Addresses", "State", c => c.String());
            AddColumn("dbo.Addresses", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "ZipCode");
            DropColumn("dbo.Addresses", "State");
            DropColumn("dbo.Addresses", "City");
            DropColumn("dbo.Addresses", "StreetAddress");
        }
    }
}
