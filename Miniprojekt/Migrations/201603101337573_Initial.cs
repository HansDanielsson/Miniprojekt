namespace Miniprojekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ColorOnScreens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        rgb = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PictureOnScreens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TextOnScreens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WrongText = c.String(),
                        OkText = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserNames",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        NickName = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.UserRecords",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        Category = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.UserNames", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRecords", "UserID", "dbo.UserNames");
            DropIndex("dbo.UserRecords", new[] { "UserID" });
            DropTable("dbo.UserRecords");
            DropTable("dbo.UserNames");
            DropTable("dbo.TextOnScreens");
            DropTable("dbo.PictureOnScreens");
            DropTable("dbo.ColorOnScreens");
        }
    }
}
