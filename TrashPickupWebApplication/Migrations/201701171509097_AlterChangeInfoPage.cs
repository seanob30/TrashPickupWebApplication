namespace TrashPickupWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterChangeInfoPage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccountTypes (ID, AccountType) VALUES (1, Customer)");
            Sql("INSERT INTO AccountTypes (ID, AccountType) VALUES (2, Worker)");
            Sql("INSERT INTO AccountTypes (ID, AccountType) VALUES (3, Administrator)");
        }
        public override void Down()
        {
        }
    }
}
