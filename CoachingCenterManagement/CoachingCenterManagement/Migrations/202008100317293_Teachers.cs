namespace CoachingCenterManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teachers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Name", c => c.String());
            AddColumn("dbo.Teachers", "Subject", c => c.String());
            AddColumn("dbo.Teachers", "Email", c => c.String());
            DropColumn("dbo.Teachers", "TeacherName");
            DropColumn("dbo.Teachers", "TeacherSubject");
            DropColumn("dbo.Teachers", "TeacherEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "TeacherEmail", c => c.String());
            AddColumn("dbo.Teachers", "TeacherSubject", c => c.String());
            AddColumn("dbo.Teachers", "TeacherName", c => c.String());
            DropColumn("dbo.Teachers", "Email");
            DropColumn("dbo.Teachers", "Subject");
            DropColumn("dbo.Teachers", "Name");
        }
    }
}
