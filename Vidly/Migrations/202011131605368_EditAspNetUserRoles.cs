namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditAspNetUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.AspNetUserRoles SET UserId = '7f20f34f-4eb6-4d5b-9b29-d06e323ed94d'");
        }
        
        public override void Down()
        {
        }
    }
}
