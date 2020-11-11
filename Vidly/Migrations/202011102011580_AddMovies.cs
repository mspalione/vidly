namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Movies SET Name = 'Die Hard', Genre = 'Action', ReleaseDate = '1988-07-15', DateAdded = '1989-01-01', NumberInStock = 6 WHERE Id = 2");
            Sql("UPDATE dbo.Movies SET Name = 'The Terminator', Genre = 'Action', ReleaseDate = '1984-10-26', DateAdded = '1985-01-01', NumberInStock = 3 WHERE Id = 3");
            Sql("UPDATE dbo.Movies SET Name = 'Toy Story', Genre = 'Family', ReleaseDate = '1995-11-22', DateAdded = '1996-01-01', NumberInStock = 1 WHERE Id = 4");
            Sql("UPDATE dbo.Movies SET Name = 'Titanic', Genre = 'Romance', ReleaseDate = '1997-12-19', DateAdded = '1998-01-01', NumberInStock = 5 WHERE Id = 5");
            Sql("DELETE FROM dbo.Movies WHERE Id = 6");
            Sql("DELETE FROM dbo.Movies WHERE Id = 7");
            Sql("DELETE FROM dbo.Movies WHERE Id = 8");
            Sql("DELETE FROM dbo.Movies WHERE Id = 9");
            Sql("DELETE FROM dbo.Movies WHERE Id = 10");
        }
        
        public override void Down()
        {
        }
    }
}
