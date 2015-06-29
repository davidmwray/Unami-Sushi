namespace UnamiSushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _06032015 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reply");
            DropTable("dbo.Comment");
        }
    }
}
