namespace Lesson_25_02_21.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DealershipMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vendor = c.String(),
                        Model = c.String(),
                        HorsePower = c.Int(nullable: false),
                        EngineSize = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cars", new[] { "Id" });
            DropTable("dbo.Cars");
        }
    }
}
