namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPaymentForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "PaymentInformationId", "dbo.PaymentInformations");
            DropIndex("dbo.AspNetUsers", new[] { "PaymentInformationId" });
            DropColumn("dbo.AspNetUsers", "PaymentInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "PaymentInformationId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "PaymentInformationId");
            AddForeignKey("dbo.AspNetUsers", "PaymentInformationId", "dbo.PaymentInformations", "ID", cascadeDelete: true);
        }
    }
}
