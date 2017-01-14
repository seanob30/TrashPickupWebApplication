namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration11 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Addresses", newName: "AddressViewModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AddressViewModels", newName: "Addresses");
        }
    }
}
