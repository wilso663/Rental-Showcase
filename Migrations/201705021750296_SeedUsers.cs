namespace RentalShowcase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6ecdcd59-5d10-4389-8233-85f540471359', N'manager@showcase.com', 0, N'AK1OcJax2kEG207G1jfZMd3xulRVzgDlkW4mlujwsDLmZuNAQG1lglNavymy62dlXg==', N'e6b12e82-a7ee-42b6-b263-24d1484daca1', NULL, 0, 0, NULL, 1, 0, N'manager@showcase.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd39c3af0-3e28-470c-a1a4-11a6bc9ce041', N'guest@showcase.com', 0, N'AFmmieI+rvbhkj14NOUC+kmyIX5HCs6VNceQc/+vRmHyW0bed2nlqctIwyDo4ckqcA==', N'72174d8b-19b8-4175-92f2-ee8b4666554c', NULL, 0, 0, NULL, 1, 0, N'guest@showcase.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1f7abbe6-16b6-4939-80b7-40449598e41f', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6ecdcd59-5d10-4389-8233-85f540471359', N'1f7abbe6-16b6-4939-80b7-40449598e41f')");
        }
        
        public override void Down()
        {
        }
    }
}
