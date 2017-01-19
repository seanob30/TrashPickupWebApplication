namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedScheduledServicesIDnames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ScheduledServices", "ServiceIntervalId_ID", "dbo.PickupIntervals");
            DropForeignKey("dbo.ScheduledServices", "ServiceTypeId_ID", "dbo.RegularServices");
            DropIndex("dbo.ScheduledServices", new[] { "ServiceIntervalId_ID" });
            DropIndex("dbo.ScheduledServices", new[] { "ServiceTypeId_ID" });
            RenameColumn(table: "dbo.ScheduledServices", name: "ServiceIntervalId_ID", newName: "PickupIntervalID");
            RenameColumn(table: "dbo.ScheduledServices", name: "ServiceTypeId_ID", newName: "RegularServiceID");
            AlterColumn("dbo.ScheduledServices", "PickupIntervalID", c => c.Int(nullable: false));
            AlterColumn("dbo.ScheduledServices", "RegularServiceID", c => c.Int(nullable: false));
            CreateIndex("dbo.ScheduledServices", "RegularServiceID");
            CreateIndex("dbo.ScheduledServices", "PickupIntervalID");
            AddForeignKey("dbo.ScheduledServices", "PickupIntervalID", "dbo.PickupIntervals", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ScheduledServices", "RegularServiceID", "dbo.RegularServices", "ID", cascadeDelete: true);
            DropColumn("dbo.ScheduledServices", "ServiceTypeID");
            DropColumn("dbo.ScheduledServices", "ServiceIntervalID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScheduledServices", "ServiceIntervalID", c => c.Int(nullable: false));
            AddColumn("dbo.ScheduledServices", "ServiceTypeID", c => c.Int(nullable: false));
            DropForeignKey("dbo.ScheduledServices", "RegularServiceID", "dbo.RegularServices");
            DropForeignKey("dbo.ScheduledServices", "PickupIntervalID", "dbo.PickupIntervals");
            DropIndex("dbo.ScheduledServices", new[] { "PickupIntervalID" });
            DropIndex("dbo.ScheduledServices", new[] { "RegularServiceID" });
            AlterColumn("dbo.ScheduledServices", "RegularServiceID", c => c.Int());
            AlterColumn("dbo.ScheduledServices", "PickupIntervalID", c => c.Int());
            RenameColumn(table: "dbo.ScheduledServices", name: "RegularServiceID", newName: "ServiceTypeId_ID");
            RenameColumn(table: "dbo.ScheduledServices", name: "PickupIntervalID", newName: "ServiceIntervalId_ID");
            CreateIndex("dbo.ScheduledServices", "ServiceTypeId_ID");
            CreateIndex("dbo.ScheduledServices", "ServiceIntervalId_ID");
            AddForeignKey("dbo.ScheduledServices", "ServiceTypeId_ID", "dbo.RegularServices", "ID");
            AddForeignKey("dbo.ScheduledServices", "ServiceIntervalId_ID", "dbo.PickupIntervals", "ID");
        }
    }
}
