namespace SuperMarketAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductAndCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatId = c.Int(nullable: false, identity: true),
                        CatName = c.String(),
                        CatDesc = c.String(),
                    })
                .PrimaryKey(t => t.CatId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProdId = c.Int(nullable: false, identity: true),
                        ProdName = c.String(),
                        ProdQty = c.Int(nullable: false),
                        ProdPrice = c.Double(nullable: false),
                        CatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdId)
                .ForeignKey("dbo.Categories", t => t.CatId, cascadeDelete: true)
                .Index(t => t.CatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CatId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CatId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
