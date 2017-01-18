namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPaymentTypesAndSeededCardTypes : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AspNetUsers", new[] { "AccountTypeId" });
            DropIndex("dbo.AspNetUsers", new[] { "CityId" });
            DropIndex("dbo.AspNetUsers", new[] { "StateId" });
            DropIndex("dbo.AspNetUsers", new[] { "ZipCodeId" });
            CreateTable(
                "dbo.PaymentInformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CardTypeId = c.Int(nullable: false),
                        CardNumber = c.Int(nullable: false),
                        ExpirationMonth = c.Int(nullable: false),
                        ExpirationYear = c.Int(nullable: false),
                        CCVCode = c.Int(nullable: false),
                        NameOnCard = c.String(),
                        ZipcodeOnCard = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CardTypes", t => t.CardTypeId, cascadeDelete: true)
                .Index(t => t.CardTypeId);
            
            CreateTable(
                "dbo.CardTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.AspNetUsers", "PaymentInformationId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUsers", "AccountTypeId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "CityId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "StateId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "ZipCodeId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "AccountTypeId");
            CreateIndex("dbo.AspNetUsers", "CityId");
            CreateIndex("dbo.AspNetUsers", "StateId");
            CreateIndex("dbo.AspNetUsers", "ZipCodeId");
            CreateIndex("dbo.AspNetUsers", "PaymentInformationId");
            AddForeignKey("dbo.AspNetUsers", "PaymentInformationId", "dbo.PaymentInformations", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "PaymentInformationId", "dbo.PaymentInformations");
            DropForeignKey("dbo.PaymentInformations", "CardTypeId", "dbo.CardTypes");
            DropIndex("dbo.PaymentInformations", new[] { "CardTypeId" });
            DropIndex("dbo.AspNetUsers", new[] { "PaymentInformationId" });
            DropIndex("dbo.AspNetUsers", new[] { "ZipCodeId" });
            DropIndex("dbo.AspNetUsers", new[] { "StateId" });
            DropIndex("dbo.AspNetUsers", new[] { "CityId" });
            DropIndex("dbo.AspNetUsers", new[] { "AccountTypeId" });
            AlterColumn("dbo.AspNetUsers", "ZipCodeId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "StateId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "AccountTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "Discriminator");
            DropColumn("dbo.AspNetUsers", "PaymentInformationId");
            DropTable("dbo.CardTypes");
            DropTable("dbo.PaymentInformations");
            CreateIndex("dbo.AspNetUsers", "ZipCodeId");
            CreateIndex("dbo.AspNetUsers", "StateId");
            CreateIndex("dbo.AspNetUsers", "CityId");
            CreateIndex("dbo.AspNetUsers", "AccountTypeId");
        }
    }
}
