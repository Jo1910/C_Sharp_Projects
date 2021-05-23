namespace CodeFirstAPp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StFirstName = c.String(),
                        StLastName = c.String(),
                        Email = c.String(),
                        SubjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SubjectID", "dbo.Subjects");
            DropIndex("dbo.Students", new[] { "SubjectID" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
        }
    }
}
