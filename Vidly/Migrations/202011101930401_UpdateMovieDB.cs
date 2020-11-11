namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 'Comedy', '2009-06-02', '2010-01-01', 4)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 'Action', '1988-07-15', '1989-01-01', 6)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 'Action', '1984-10-26', '1985-01-01', 3)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 'Family', '1995-11-22', '1996-01-01', 1)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 'Romance', '1997-12-19', '1998-01-01', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
