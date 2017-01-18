namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsernameOnPaymentInfoAndFixedtypo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentInformations", "CustomerName", c => c.String());
            AddColumn("dbo.ScheduledServices", "ScheduledUser", c => c.String());
            DropColumn("dbo.ScheduledServices", "SeceduledUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScheduledServices", "SeceduledUser", c => c.String());
            DropColumn("dbo.ScheduledServices", "ScheduledUser");
            DropColumn("dbo.PaymentInformations", "CustomerName");
        }
    }
}
