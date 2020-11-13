namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f20f34f-4eb6-4d5b-9b29-d06e323ed94d', N'admin@vidly.com', 0, N'AFuggzF6yYKeFvBxUunXfm4IzgRMbI/G768knjxaGK1H6feL2JfvfbalqOgc3ORYMw==', N'a30cb186-ca8d-4848-b172-4eb9e0d1fef8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dcc953cc-ca83-41b3-a070-59cc24648ea6', N'guest@vidly.com', 0, N'AOeol1pOBhdADDF4BjrtuQLB22fx6rF+gKOcjxxEyx0nTaZxPF4VRP+JqYnfqmEqgA==', N'd0dbcf11-134f-4cc9-96a8-f6d0a1a672c7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6addb78b-9ea9-4b15-a995-7113281cece4', N'CanManageMovie')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dcc953cc-ca83-41b3-a070-59cc24648ea6', N'6addb78b-9ea9-4b15-a995-7113281cece4')
                
                ");
        }
        
        public override void Down()
        {
        }
    }
}
