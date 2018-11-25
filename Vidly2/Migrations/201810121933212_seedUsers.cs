namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc6d6b61-0fcb-4b67-8afd-be3667bd8e99', N'guest@vidly.com', 0, N'ANJ2s0aC9mTEcDMwFb7XTcqm/1vF3u+0mnsOieIqi68r4lxAGT7FqmgrYANisjw9KA==', N'429277e2-8bb0-4b36-b75a-10b575668d3c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf0e60d8-d052-4f62-bb41-f25d5947b71e', N'moviemanage@vidly.com', 0, N'AC1K7arks01KIOjzFYdVLixZEhNa07fY79kxbq7F02MJ2baDVuXyfzUzW7FPYon6EA==', N'55771e22-5706-444a-88b8-cb0cee6585cd', NULL, 0, 0, NULL, 1, 0, N'moviemanage@vidly.com')

");

            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'25e51da3-4c89-477a-9a8b-af1e0bc6c752', N'CanManageMovie')

            ");

            Sql(@"
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf0e60d8-d052-4f62-bb41-f25d5947b71e', N'25e51da3-4c89-477a-9a8b-af1e0bc6c752')
            ");
        }

        
        
        public override void Down()
        {
        }
    }
}
