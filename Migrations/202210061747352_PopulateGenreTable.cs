namespace Filmoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (3, 'Adventure')");
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (5, 'Sci.fi')");
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (6, 'Drama')");
            Sql("INSERT INTO Genres (Id, MovieGenre) VALUES (7, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
