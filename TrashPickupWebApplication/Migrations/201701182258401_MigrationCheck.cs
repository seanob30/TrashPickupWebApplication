namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationCheck : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AspNetUsers", new[] { "AccountTypeId" });
            DropIndex("dbo.AspNetUsers", new[] { "CityId" });
            DropIndex("dbo.AspNetUsers", new[] { "StateId" });
            DropIndex("dbo.AspNetUsers", new[] { "ZipCodeId" });
            DropIndex("dbo.AspNetUsers", new[] { "PaymentInformationId" });
            AlterColumn("dbo.AspNetUsers", "AccountTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "StateId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "ZipCodeId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "PaymentInformationId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "AccountTypeId");
            CreateIndex("dbo.AspNetUsers", "CityId");
            CreateIndex("dbo.AspNetUsers", "StateId");
            CreateIndex("dbo.AspNetUsers", "ZipCodeId");
            CreateIndex("dbo.AspNetUsers", "PaymentInformationId");
            DropColumn("dbo.AspNetUsers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropIndex("dbo.AspNetUsers", new[] { "PaymentInformationId" });
            DropIndex("dbo.AspNetUsers", new[] { "ZipCodeId" });
            DropIndex("dbo.AspNetUsers", new[] { "StateId" });
            DropIndex("dbo.AspNetUsers", new[] { "CityId" });
            DropIndex("dbo.AspNetUsers", new[] { "AccountTypeId" });
            AlterColumn("dbo.AspNetUsers", "PaymentInformationId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "ZipCodeId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "StateId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "CityId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "AccountTypeId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "PaymentInformationId");
            CreateIndex("dbo.AspNetUsers", "ZipCodeId");
            CreateIndex("dbo.AspNetUsers", "StateId");
            CreateIndex("dbo.AspNetUsers", "CityId");
            CreateIndex("dbo.AspNetUsers", "AccountTypeId");
        }
    }
}
