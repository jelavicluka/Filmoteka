namespace Filmoteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8e0bb6f4-2f27-4491-a740-6a7ebb215aed', N'guest@filmoteka.com', 0, N'APZhiacpxkGkYD71gKRC1wJ5JwwJ5/twJczkdcCXAU+OOSqp3+6zYHnQep19PSk2ig==', N'c57ea965-fb33-4de0-8951-7b44badec4a2', NULL, 0, 0, NULL, 1, 0, N'guest@filmoteka.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5eaa7a1-e1ad-49a4-90fa-637d682404e3', N'admin@filmoteka.com', 0, N'ANqBsTzv4FXvd97ltyh81h2dfobj4bYUQUXqDohYi1Q8Z7CCp5AU5+QbxltH3YTfmw==', N'6747fe41-db67-41fb-926c-3ccc99733463', NULL, 0, 0, NULL, 1, 0, N'admin@filmoteka.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6f428ecb-a5f3-4993-abe9-f1296e214b50', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5eaa7a1-e1ad-49a4-90fa-637d682404e3', N'6f428ecb-a5f3-4993-abe9-f1296e214b50')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
