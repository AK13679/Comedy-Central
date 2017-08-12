namespace ComedyCentral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConv : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comedies", "Artist_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comedies", "Description_Id", "dbo.Descriptions");
            DropIndex("dbo.Comedies", new[] { "Artist_Id" });
            DropIndex("dbo.Comedies", new[] { "Description_Id" });
            AlterColumn("dbo.Comedies", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Comedies", "Artist_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Comedies", "Description_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Descriptions", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Comedies", "Artist_Id");
            CreateIndex("dbo.Comedies", "Description_Id");
            AddForeignKey("dbo.Comedies", "Artist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comedies", "Description_Id", "dbo.Descriptions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comedies", "Description_Id", "dbo.Descriptions");
            DropForeignKey("dbo.Comedies", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comedies", new[] { "Description_Id" });
            DropIndex("dbo.Comedies", new[] { "Artist_Id" });
            AlterColumn("dbo.Descriptions", "Name", c => c.String());
            AlterColumn("dbo.Comedies", "Description_Id", c => c.Byte());
            AlterColumn("dbo.Comedies", "Artist_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Comedies", "Venue", c => c.String());
            CreateIndex("dbo.Comedies", "Description_Id");
            CreateIndex("dbo.Comedies", "Artist_Id");
            AddForeignKey("dbo.Comedies", "Description_Id", "dbo.Descriptions", "Id");
            AddForeignKey("dbo.Comedies", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
