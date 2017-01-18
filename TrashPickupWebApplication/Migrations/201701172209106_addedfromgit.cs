namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfromgit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserInfoes", "ApplicationUserId");
            AddForeignKey("dbo.UserInfoes", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserInfoes", new[] { "ApplicationUserId" });
            DropColumn("dbo.UserInfoes", "ApplicationUserId");
        }
    }
}
