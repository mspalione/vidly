namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenreIdColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Movies SET GenreId = Genres.Id FROM Movies, Genres WHERE Movies.Genre = Genres.GenreType");
        }
        
        public override void Down()
        {
        }
    }
}
