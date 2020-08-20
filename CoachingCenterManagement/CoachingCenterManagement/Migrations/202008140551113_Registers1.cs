namespace CoachingCenterManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registers1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Registers", "ConfirmPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registers", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Registers", "Password", c => c.String());
            AlterColumn("dbo.Registers", "Email", c => c.String());
            AlterColumn("dbo.Registers", "LastName", c => c.String());
            AlterColumn("dbo.Registers", "FirstName", c => c.String());
        }
    }
}
