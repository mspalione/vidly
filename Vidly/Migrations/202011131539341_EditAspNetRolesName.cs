namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditAspNetRolesName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.AspNetRoles SET Name = 'CanManageMovies'");
        }
        
        public override void Down()
        {
        }
    }
}
