namespace NetProject.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdfasdf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        MyProperty = c.Int(nullable: false),
                        InsertedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        BrandId = c.Int(nullable: false),
                        InsertedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "BrandId", "dbo.Brand");
            DropIndex("dbo.Product", new[] { "BrandId" });
            DropTable("dbo.Product");
            DropTable("dbo.Brand");
        }
    }
}
