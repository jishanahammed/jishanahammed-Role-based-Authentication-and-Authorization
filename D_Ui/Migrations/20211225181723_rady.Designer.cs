﻿// <auto-generated />
using System;
using D_Ui.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace D_Ui.Migrations
{
    [DbContext(typeof(DuiContext))]
    [Migration("20211225181723_rady")]
    partial class rady
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("D_Ui.Models.Domain.Auth.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "0f04028e-587c-47ad-8b36-6dbd6a059fa4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d1",
                            Department = "Developer",
                            Designation = "Admin",
                            Email = "jishan.bd46@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "JISHAN.BD46@GMAIL.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J6I",
                            TwoFactorEnabled = false,
                            UserName = "administrator"
                        },
                        new
                        {
                            Id = "0f04028e-587c-48ad-8b36-6dbd6a059fa5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d2",
                            Department = "Developer",
                            Designation = "librarian",
                            Email = "librarian@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Librarian",
                            LockoutEnabled = false,
                            NormalizedEmail = "LIBRARIAN@GMAIL.COM",
                            NormalizedUserName = "LIBRARIAN",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J62",
                            TwoFactorEnabled = false,
                            UserName = "librarian"
                        },
                        new
                        {
                            Id = "0f04028e-587c-67ad-8b36-6dbd6a059fa6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d3",
                            Department = "Developer",
                            Designation = "Cafeteria",
                            Email = "cafeteria@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Cafeteria",
                            LockoutEnabled = false,
                            NormalizedEmail = "CAFETERIA@GMAIL.COM",
                            NormalizedUserName = "CAFETERIA",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J63",
                            TwoFactorEnabled = false,
                            UserName = "cafeteria"
                        },
                        new
                        {
                            Id = "0f04028e-587c-17ad-8b36-6dbd6a059fa7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d5",
                            Department = "Developer",
                            Designation = "Dormitory",
                            Email = "dormitory@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Dormitory",
                            LockoutEnabled = false,
                            NormalizedEmail = "DORMITORY@GMAIL.COM",
                            NormalizedUserName = "DORMITORY",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J65",
                            TwoFactorEnabled = false,
                            UserName = "dormitory"
                        },
                        new
                        {
                            Id = "0f04028e-587c-77ad-8b36-6dbd6a059fa8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d6",
                            Department = "Developer",
                            Designation = "Manager",
                            Email = "manager@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Manager",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@GMAIL.COM",
                            NormalizedUserName = "MANAGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J66",
                            TwoFactorEnabled = false,
                            UserName = "manager"
                        },
                        new
                        {
                            Id = "0f04028e-587c-57ad-8b36-6dbd6a057fa9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d8",
                            Department = "Developer",
                            Designation = "Reception",
                            Email = "reception@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Reception",
                            LockoutEnabled = false,
                            NormalizedEmail = "RECEPTION@GMAIL.COM",
                            NormalizedUserName = "RECEPTION",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J68",
                            TwoFactorEnabled = false,
                            UserName = "reception"
                        },
                        new
                        {
                            Id = "0f04028e-587c-37ad-8b36-6dbd6a059fa10",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "616a2e8f-dc94-4576-8ec4-c9d75d1df6d9",
                            Department = "Developer",
                            Designation = "Candidate",
                            Email = "candidate@gmail.com",
                            EmailConfirmed = true,
                            FullName = "System Candidate",
                            LockoutEnabled = false,
                            NormalizedEmail = "CANDIDATE@GMAIL.COM",
                            NormalizedUserName = "CANDIDATE",
                            PasswordHash = "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==",
                            PhoneNumber = "01840019826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J60",
                            TwoFactorEnabled = false,
                            UserName = "candidate"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "c542843d-26f3-4713-8f38-93294bbb509b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            ConcurrencyStamp = "a077af14-7529-435a-a102-f46cd07fd9fa",
                            Name = "Librarian",
                            NormalizedName = "LIBRARIAN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                            ConcurrencyStamp = "ef7ef5d7-a28e-4192-98c1-501865d7f5c5",
                            Name = "Cafeteria",
                            NormalizedName = "CAFETERIA"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7213",
                            ConcurrencyStamp = "91b1099a-e808-4538-9db2-4d961ae42d5b",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7214",
                            ConcurrencyStamp = "5e5f351c-cf9f-4af2-abf7-fcd303543015",
                            Name = "Dormitory",
                            NormalizedName = "DORMITORY"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7215",
                            ConcurrencyStamp = "dd88c095-0362-46fc-8258-ec3a0129d474",
                            Name = "Reception",
                            NormalizedName = "RECEPTION"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7216",
                            ConcurrencyStamp = "030621fb-d183-4635-ac74-85b15c47e53c",
                            Name = "Candidate",
                            NormalizedName = "CANDIDATE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "0f04028e-587c-47ad-8b36-6dbd6a059fa4",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        },
                        new
                        {
                            UserId = "0f04028e-587c-48ad-8b36-6dbd6a059fa5",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "0f04028e-587c-67ad-8b36-6dbd6a059fa6",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212"
                        },
                        new
                        {
                            UserId = "0f04028e-587c-17ad-8b36-6dbd6a059fa7",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7213"
                        },
                        new
                        {
                            UserId = "0f04028e-587c-17ad-8b36-6dbd6a059fa7",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7214"
                        },
                        new
                        {
                            UserId = "0f04028e-587c-57ad-8b36-6dbd6a057fa9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7215"
                        },
                        new
                        {
                            UserId = "0f04028e-587c-37ad-8b36-6dbd6a059fa10",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7216"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("D_Ui.Models.Domain.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("D_Ui.Models.Domain.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("D_Ui.Models.Domain.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("D_Ui.Models.Domain.Auth.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
