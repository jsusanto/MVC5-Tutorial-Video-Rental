namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'32838027-db5d-4061-ad4d-40a04e88c2ad', N'admin@jsusanto.com', 0, N'ALjDQl/LRklbeyFNkLbgXlFI13GjM5va+59q4ROm/3W4aFff4zKoBeyYcwGLNRxVHg==', N'4c0abc0c-5a66-45d5-9e0c-93bfe9cd3e81', NULL, 0, 0, NULL, 1, 0, N'admin@jsusanto.com')
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'b2d447ab-b6e0-4fbb-b980-844aa5201077', N'guest@jsusanto.com', 0, N'ALOOZoDh7G5nMzSqmPLdJ01RBR0LrjVwbwhyTgRMxDLzL3X3SZp84AaAtFRf4bJ0lQ==', N'14cf0d5d-a3f1-46d3-a8ec-40543ebd69ba', NULL, 0, 0, NULL, 1, 0, N'guest@jsusanto.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'af529c43-c12c-4568-b85c-3dd0fe606f00', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'32838027-db5d-4061-ad4d-40a04e88c2ad', N'af529c43-c12c-4568-b85c-3dd0fe606f00')
            ");

        }

    public override void Down()
        {
        }
    }
}
