namespace CoachingCenterManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admission1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admissions", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Admissions", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Admissions", "FatherName", c => c.String(nullable: false));
            AlterColumn("dbo.Admissions", "MotherName", c => c.String(nullable: false));
            AlterColumn("dbo.Admissions", "PermanentAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Admissions", "PhoneNumber", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admissions", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Admissions", "PermanentAddress", c => c.String());
            AlterColumn("dbo.Admissions", "MotherName", c => c.String());
            AlterColumn("dbo.Admissions", "FatherName", c => c.String());
            AlterColumn("dbo.Admissions", "LastName", c => c.String());
            AlterColumn("dbo.Admissions", "FirstName", c => c.String());
        }
    }
}
