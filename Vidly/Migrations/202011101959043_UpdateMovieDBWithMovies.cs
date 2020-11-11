namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieDBWithMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Movies SET Name = 'Hangover', Genre = 'Comedy', ReleaseDate = '2009-06-02', DateAdded = '2010-01-01', NumberInStock = 4, WHERE Id = 1");
        }
        
        public override void Down()
        {
           
        }
    }
}
