namespace Lesson_25_02_21.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleBuyeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        DateTime = c.DateTime(nullable: false),
                        Buyer_Id = c.Int(),
                        Car_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .Index(t => t.Id)
                .Index(t => t.Buyer_Id)
                .Index(t => t.Car_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Sales", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Sales", new[] { "Car_Id" });
            DropIndex("dbo.Sales", new[] { "Buyer_Id" });
            DropIndex("dbo.Sales", new[] { "Id" });
            DropIndex("dbo.Buyers", new[] { "Id" });
            DropTable("dbo.Sales");
            DropTable("dbo.Buyers");
        }
    }
}
