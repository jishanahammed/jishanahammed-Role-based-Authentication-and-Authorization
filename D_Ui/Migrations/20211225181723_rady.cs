using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace D_Ui.Migrations
{
    public partial class rady : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "c542843d-26f3-4713-8f38-93294bbb509b", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a077af14-7529-435a-a102-f46cd07fd9fa", "Librarian", "LIBRARIAN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "ef7ef5d7-a28e-4192-98c1-501865d7f5c5", "Cafeteria", "CAFETERIA" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7213", "91b1099a-e808-4538-9db2-4d961ae42d5b", "Manager", "MANAGER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7214", "5e5f351c-cf9f-4af2-abf7-fcd303543015", "Dormitory", "DORMITORY" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7215", "dd88c095-0362-46fc-8258-ec3a0129d474", "Reception", "RECEPTION" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7216", "030621fb-d183-4635-ac74-85b15c47e53c", "Candidate", "CANDIDATE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Department", "Designation", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f04028e-587c-47ad-8b36-6dbd6a059fa4", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d1", "Developer", "Admin", "jishan.bd46@gmail.com", true, "System Admin", false, null, "JISHAN.BD46@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J6I", false, "administrator" },
                    { "0f04028e-587c-48ad-8b36-6dbd6a059fa5", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d2", "Developer", "librarian", "librarian@gmail.com", true, "System Librarian", false, null, "LIBRARIAN@GMAIL.COM", "LIBRARIAN", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J62", false, "librarian" },
                    { "0f04028e-587c-67ad-8b36-6dbd6a059fa6", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d3", "Developer", "Cafeteria", "cafeteria@gmail.com", true, "System Cafeteria", false, null, "CAFETERIA@GMAIL.COM", "CAFETERIA", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J63", false, "cafeteria" },
                    { "0f04028e-587c-17ad-8b36-6dbd6a059fa7", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d5", "Developer", "Dormitory", "dormitory@gmail.com", true, "System Dormitory", false, null, "DORMITORY@GMAIL.COM", "DORMITORY", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J65", false, "dormitory" },
                    { "0f04028e-587c-77ad-8b36-6dbd6a059fa8", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d6", "Developer", "Manager", "manager@gmail.com", true, "System Manager", false, null, "MANAGER@GMAIL.COM", "MANAGER", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J66", false, "manager" },
                    { "0f04028e-587c-57ad-8b36-6dbd6a057fa9", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d8", "Developer", "Reception", "reception@gmail.com", true, "System Reception", false, null, "RECEPTION@GMAIL.COM", "RECEPTION", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J68", false, "reception" },
                    { "0f04028e-587c-37ad-8b36-6dbd6a059fa10", 0, "616a2e8f-dc94-4576-8ec4-c9d75d1df6d9", "Developer", "Candidate", "candidate@gmail.com", true, "System Candidate", false, null, "CANDIDATE@GMAIL.COM", "CANDIDATE", "AQAAAAEAACcQAAAAEE8d8uAFK+zBNJ3j+s3k5c6D+OqrJJqgpV0CF42z2UDwqm/kSD/LWNXN8OAx/56YHg==", "01840019826", true, "37QJAUUNCSSXNFFB6ZXI6OJLHSCS5J60", false, "candidate" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "0f04028e-587c-47ad-8b36-6dbd6a059fa4", "2c5e174e-3b0e-446f-86af-483d56fd7210" },
                    { "0f04028e-587c-48ad-8b36-6dbd6a059fa5", "2c5e174e-3b0e-446f-86af-483d56fd7211" },
                    { "0f04028e-587c-67ad-8b36-6dbd6a059fa6", "2c5e174e-3b0e-446f-86af-483d56fd7212" },
                    { "0f04028e-587c-17ad-8b36-6dbd6a059fa7", "2c5e174e-3b0e-446f-86af-483d56fd7213" },
                    { "0f04028e-587c-17ad-8b36-6dbd6a059fa7", "2c5e174e-3b0e-446f-86af-483d56fd7214" },
                    { "0f04028e-587c-57ad-8b36-6dbd6a057fa9", "2c5e174e-3b0e-446f-86af-483d56fd7215" },
                    { "0f04028e-587c-37ad-8b36-6dbd6a059fa10", "2c5e174e-3b0e-446f-86af-483d56fd7216" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
