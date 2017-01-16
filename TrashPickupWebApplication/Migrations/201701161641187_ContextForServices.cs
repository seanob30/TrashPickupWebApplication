namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextForServices : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduledServices", "ServiceTypeId_ID", "dbo.RegularServices");
            DropForeignKey("dbo.ScheduledServices", "ServiceIntervalId_ID", "dbo.PickupIntervals");
            DropIndex("dbo.ScheduledServices", new[] { "ServiceTypeId_ID" });
            DropIndex("dbo.ScheduledServices", new[] { "ServiceIntervalId_ID" });
            DropTable("dbo.ScheduledServices");
            DropTable("dbo.RegularServices");
            DropTable("dbo.PickupIntervals");
            DropTable("dbo.Days");
        }
    }
}
