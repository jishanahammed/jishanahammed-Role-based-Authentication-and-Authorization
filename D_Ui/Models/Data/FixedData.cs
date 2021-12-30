using D_Ui.Models.Domain.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace D_Ui.Models.Data
{
    public class FixedData
    {
        public static void SeedData(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Librarian", NormalizedName = "LIBRARIAN" },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", Name = "Cafeteria", NormalizedName = "CAFETERIA" },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7213", Name = "Manager", NormalizedName = "MANAGER" },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7214", Name = "Dormitory", NormalizedName = "DORMITORY" },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7215", Name = "Reception", NormalizedName = "RECEPTION" },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7216", Name = "Candidate", NormalizedName = "CANDIDATE" }
           );
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "0f04028e-587c-47ad-8b36-6dbd6a059fa4",
                    PhoneNumber = "01840019826",
                    Email = "jishan.bd46@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Admin",
                    LockoutEnabled = false,
                    NormalizedEmail = "JISHAN.BD46@GMAIL.COM",
                    NormalizedUserName = "ADMINISTRATOR",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d1",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J6I",
                    TwoFactorEnabled = false,
                    UserName = "administrator",
                    Designation = "Admin",
                    Department = "Developer",
                    UserType=3
                },
                new ApplicationUser
                {
                    Id = "0f04028e-587c-48ad-8b36-6dbd6a059fa5",
                    PhoneNumber = "01840019826",
                    Email = "librarian@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Librarian",
                    LockoutEnabled = false,
                    NormalizedEmail = "LIBRARIAN@GMAIL.COM",
                    NormalizedUserName = "LIBRARIAN",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d2",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J62",
                    TwoFactorEnabled = false,
                    UserName = "librarian",
                    Designation = "librarian",
                    Department = "Developer",
                    UserType = 3
                },
                new ApplicationUser
                {
                    Id = "0f04028e-587c-67ad-8b36-6dbd6a059fa6",
                    PhoneNumber = "01840019826",
                    Email = "cafeteria@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Cafeteria",
                    LockoutEnabled = false,
                    NormalizedEmail = "CAFETERIA@GMAIL.COM",
                    NormalizedUserName = "CAFETERIA",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d3",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J63",
                    TwoFactorEnabled = false,
                    UserName = "cafeteria",
                    Designation = "Cafeteria",
                    Department = "Developer",
                    UserType = 3
                },
                new ApplicationUser
                {
                    Id = "0f04028e-587c-17ad-8b36-6dbd6a059fa7",
                    PhoneNumber = "01840019826",
                    Email = "dormitory@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Dormitory",
                    LockoutEnabled = false,
                    NormalizedEmail = "DORMITORY@GMAIL.COM",
                    NormalizedUserName = "DORMITORY",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d5",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J65",
                    TwoFactorEnabled = false,
                    UserName = "dormitory",
                    Designation = "Dormitory",
                    Department = "Developer",
                    UserType = 3
                },
                new ApplicationUser
                {
                    Id = "0f04028e-587c-77ad-8b36-6dbd6a059fa8",
                    PhoneNumber = "01840019826",
                    Email = "manager@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Manager",
                    LockoutEnabled = false,
                    NormalizedEmail = "MANAGER@GMAIL.COM",
                    NormalizedUserName = "MANAGER",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d6",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J66",
                    TwoFactorEnabled = false,
                    UserName = "manager",
                    Designation = "Manager",
                    Department = "Developer",
                    UserType = 3
                },
                new ApplicationUser
                {
                    Id = "0f04028e-587c-57ad-8b36-6dbd6a057fa9",
                    PhoneNumber = "01840019826",
                    Email = "reception@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Reception",
                    LockoutEnabled = false,
                    NormalizedEmail = "RECEPTION@GMAIL.COM",
                    NormalizedUserName = "RECEPTION",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d8",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J68",
                    TwoFactorEnabled = false,
                    UserName = "reception",
                    Designation = "Reception",
                    Department = "Developer",
                    UserType = 3
                },
                new ApplicationUser
                {
                    Id = "0f04028e-587c-37ad-8b36-6dbd6a059fa10",
                    PhoneNumber = "01840019826",
                    Email = "candidate@gmail.com",
                    EmailConfirmed = true,
                    FullName = "System Candidate",
                    LockoutEnabled = false,
                    NormalizedEmail = "CANDIDATE@GMAIL.COM",
                    NormalizedUserName = "CANDIDATE",
                    PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                    ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d9",
                    PhoneNumberConfirmed = true,
                    SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J60",
                    TwoFactorEnabled = false,
                    UserName = "candidate",
                    Designation = "Candidate",
                    Department = "Developer",
                    UserType = 3
                }
            );


            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "0f04028e-587c-47ad-8b36-6dbd6a059fa4"
            },

            //librarian
             new IdentityUserRole<string>
             {
                 RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                 UserId = "0f04028e-587c-48ad-8b36-6dbd6a059fa5"
             },

            //Cafeteria
             new IdentityUserRole<string>
             {
                 RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                 UserId = "0f04028e-587c-67ad-8b36-6dbd6a059fa6"
             },

             //Manager
             new IdentityUserRole<string>
             {
                 RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7213",
                 UserId = "0f04028e-587c-17ad-8b36-6dbd6a059fa7"
             },

             //Dormitory
             new IdentityUserRole<string>
             {
                 RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7214",
                 UserId = "0f04028e-587c-17ad-8b36-6dbd6a059fa7"
             },
             //Reception
             new IdentityUserRole<string>
             {
                 RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7215",
                 UserId = "0f04028e-587c-57ad-8b36-6dbd6a057fa9"
             },
             //Candidate
             new IdentityUserRole<string>
             {
                 RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7216",
                 UserId = "0f04028e-587c-37ad-8b36-6dbd6a059fa10"
             }
         );
        }


    }
}
