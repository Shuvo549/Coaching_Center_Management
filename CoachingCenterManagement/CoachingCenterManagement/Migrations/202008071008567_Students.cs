namespace CoachingCenterManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Students : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentRoll = c.Int(nullable: false),
                        StudentName = c.String(),
                        phone = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        BloodGroup = c.String(),
                        Gender = c.String(),
                        Religion = c.String(),
                        Nationality = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
