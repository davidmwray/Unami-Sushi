namespace UnamiSushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuCategory",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Subcategory",
                c => new
                    {
                        SubcategoryID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        SubcategoryName = c.String(),
                        SubcategoryDescription = c.String(),
                    })
                .PrimaryKey(t => t.SubcategoryID)
                .ForeignKey("dbo.MenuCategory", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.MenuItem",
                c => new
                    {
                        MenuItemID = c.Int(nullable: false, identity: true),
                        SubcategoryID = c.Int(nullable: false),
                        MenuItemName = c.String(),
                        Piece = c.Int(nullable: false),
                        Cooked = c.Boolean(nullable: false),
                        Vegetarian = c.Boolean(nullable: false),
                        MenuItemDescription = c.String(),
                        MenuItemPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MenuItemID)
                .ForeignKey("dbo.Subcategory", t => t.SubcategoryID, cascadeDelete: true)
                .Index(t => t.SubcategoryID);
            
            CreateTable(
                "dbo.MenuPicture",
                c => new
                    {
                        PictureID = c.Int(nullable: false, identity: true),
                        MenuItemID = c.Int(nullable: false),
                        PicturePathname = c.String(),
                        ThumbnailPathname = c.String(),
                    })
                .PrimaryKey(t => t.PictureID)
                .ForeignKey("dbo.MenuItem", t => t.MenuItemID, cascadeDelete: true)
                .Index(t => t.MenuItemID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subcategory", "CategoryID", "dbo.MenuCategory");
            DropForeignKey("dbo.MenuItem", "SubcategoryID", "dbo.Subcategory");
            DropForeignKey("dbo.MenuPicture", "MenuItemID", "dbo.MenuItem");
            DropIndex("dbo.MenuPicture", new[] { "MenuItemID" });
            DropIndex("dbo.MenuItem", new[] { "SubcategoryID" });
            DropIndex("dbo.Subcategory", new[] { "CategoryID" });
            DropTable("dbo.MenuPicture");
            DropTable("dbo.MenuItem");
            DropTable("dbo.Subcategory");
            DropTable("dbo.MenuCategory");
        }
    }
}
