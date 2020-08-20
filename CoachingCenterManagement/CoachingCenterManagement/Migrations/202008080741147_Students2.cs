namespace CoachingCenterManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "phone", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "phone", c => c.String(nullable: false));
        }
    }
}
