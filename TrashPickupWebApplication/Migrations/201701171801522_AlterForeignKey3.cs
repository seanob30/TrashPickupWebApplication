namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForeignKey3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "StreetAddress");
            DropColumn("dbo.Addresses", "City");
            DropColumn("dbo.Addresses", "State");
            DropColumn("dbo.Addresses", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Addresses", "State", c => c.String());
            AddColumn("dbo.Addresses", "City", c => c.String());
            AddColumn("dbo.Addresses", "StreetAddress", c => c.String());
        }
    }
}
