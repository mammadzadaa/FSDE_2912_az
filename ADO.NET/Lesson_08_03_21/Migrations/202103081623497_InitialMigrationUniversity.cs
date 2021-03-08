namespace Lesson_08_03_21.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationUniversity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.TeacherGroups",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Group_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Group_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.TeacherGroups", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Group_Id", "dbo.Groups");
            DropIndex("dbo.TeacherGroups", new[] { "Group_Id" });
            DropIndex("dbo.TeacherGroups", new[] { "Teacher_Id" });
            DropIndex("dbo.Teachers", new[] { "Id" });
            DropIndex("dbo.Students", new[] { "Group_Id" });
            DropIndex("dbo.Students", new[] { "Id" });
            DropIndex("dbo.Groups", new[] { "Id" });
            DropTable("dbo.TeacherGroups");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
        }
    }
}
