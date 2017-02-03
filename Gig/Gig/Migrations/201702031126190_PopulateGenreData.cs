namespace Gig.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO dbo.Genres (Id, Name) VALUES (4, 'Classic')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
