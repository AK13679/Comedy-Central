namespace ComedyCentral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mod : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comedies", name: "Artist_Id", newName: "ArtistId");
            RenameColumn(table: "dbo.Comedies", name: "Description_Id", newName: "DescriptionId");
            RenameIndex(table: "dbo.Comedies", name: "IX_Artist_Id", newName: "IX_ArtistId");
            RenameIndex(table: "dbo.Comedies", name: "IX_Description_Id", newName: "IX_DescriptionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Comedies", name: "IX_DescriptionId", newName: "IX_Description_Id");
            RenameIndex(table: "dbo.Comedies", name: "IX_ArtistId", newName: "IX_Artist_Id");
            RenameColumn(table: "dbo.Comedies", name: "DescriptionId", newName: "Description_Id");
            RenameColumn(table: "dbo.Comedies", name: "ArtistId", newName: "Artist_Id");
        }
    }
}
