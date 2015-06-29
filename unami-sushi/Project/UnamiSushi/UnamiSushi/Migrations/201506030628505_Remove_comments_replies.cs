namespace UnamiSushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove_comments_replies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "MenuItemID", "dbo.MenuItem");
            DropIndex("dbo.Comment", new[] { "MenuItemID" });
            DropTable("dbo.Comment");
            DropTable("dbo.Reply");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reply",
                c => new
                    {
                        ReplyID = c.Int(nullable: false, identity: true),
                        CommentID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        CommentDate = c.DateTime(nullable: false),
                        CommentContents = c.String(),
                    })
                .PrimaryKey(t => t.ReplyID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        MenuItemID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        CommentDate = c.DateTime(nullable: false),
                        CommentContents = c.String(),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateIndex("dbo.Comment", "MenuItemID");
            AddForeignKey("dbo.Comment", "MenuItemID", "dbo.MenuItem", "MenuItemID", cascadeDelete: true);
        }
    }
}
