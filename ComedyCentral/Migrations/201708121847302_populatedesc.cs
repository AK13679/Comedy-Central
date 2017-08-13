namespace ComedyCentral.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populatedesc : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Descriptions (Id, Name) VALUES (1, 'Spoof')");
            Sql("INSERT INTO Descriptions (Id, Name) VALUES (2, 'Sitcom')");
            Sql("INSERT INTO Descriptions (Id, Name) VALUES (3, 'Insult Comedy')");
            Sql("INSERT INTO Descriptions (Id, Name) VALUES (4, 'Black comedy')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Descriptions WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
