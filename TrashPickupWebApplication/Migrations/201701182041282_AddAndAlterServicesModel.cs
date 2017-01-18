namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndAlterServicesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScheduledServices", "SeceduledUser", c => c.String());
            AddColumn("dbo.ScheduledServices", "DayId", c => c.Int(nullable: false));
            AddColumn("dbo.ScheduledServices", "Days_ID", c => c.Int());
            AlterColumn("dbo.ScheduledServices", "ServiceTypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.ScheduledServices", "ServiceIntervalID", c => c.Int(nullable: false));
            CreateIndex("dbo.ScheduledServices", "Days_ID");
            AddForeignKey("dbo.ScheduledServices", "Days_ID", "dbo.Days", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduledServices", "Days_ID", "dbo.Days");
            DropIndex("dbo.ScheduledServices", new[] { "Days_ID" });
            AlterColumn("dbo.ScheduledServices", "ServiceIntervalID", c => c.String());
            AlterColumn("dbo.ScheduledServices", "ServiceTypeID", c => c.String());
            DropColumn("dbo.ScheduledServices", "Days_ID");
            DropColumn("dbo.ScheduledServices", "DayId");
            DropColumn("dbo.ScheduledServices", "SeceduledUser");
        }
    }
}
