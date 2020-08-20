namespace CoachingCenterManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "phone", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "BloodGroup", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Religion", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Nationality", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Nationality", c => c.String());
            AlterColumn("dbo.Students", "Religion", c => c.String());
            AlterColumn("dbo.Students", "Gender", c => c.String());
            AlterColumn("dbo.Students", "BloodGroup", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "phone", c => c.String());
            AlterColumn("dbo.Students", "StudentName", c => c.String());
        }
    }
}
