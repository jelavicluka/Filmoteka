namespace Filmoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckForNewMigrationsWithPhoneNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MobilePhoneNumber", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MobilePhoneNumber");
        }
    }
}
