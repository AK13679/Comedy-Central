namespace ComedyCentral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcomedy1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comedies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Artist_Id = c.String(maxLength: 128),
                        Description_Id = c.Byte(),
                    })

                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Artist_Id)
                .ForeignKey("dbo.Descriptions", t => t.Description_Id)
                .Index(t => t.Artist_Id)
                .Index(t => t.Description_Id);
            
            CreateTable(
                "dbo.Descriptions",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comedies", "Description_Id", "dbo.Descriptions");
            DropForeignKey("dbo.Comedies", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comedies", new[] { "Description_Id" });
            DropIndex("dbo.Comedies", new[] { "Artist_Id" });
            DropTable("dbo.Descriptions");
            DropTable("dbo.Comedies");
        }
    }
}
