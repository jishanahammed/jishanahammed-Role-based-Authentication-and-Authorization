using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace D_Ui.Migrations
{
    public partial class kkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5d484611-1a75-4216-ad7b-a872c9db659e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "681312d2-76db-4513-8920-cafa00a10dc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "18a1a72d-2d0e-457c-b6d5-7bda88c74361");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "d9c50bd7-daaa-4495-ae30-1fdaff7ff26f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7214",
                column: "ConcurrencyStamp",
                value: "6b0ec612-5618-4045-95b1-ea89a57b9b37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7215",
                column: "ConcurrencyStamp",
                value: "55d9f7dc-9462-46c3-97f3-c13f6d04306d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7216",
                column: "ConcurrencyStamp",
                value: "080b495a-0c83-46b2-961c-7a800856a27e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-17ad-8b36-6dbd6a059fa7",
                column: "UserType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-37ad-8b36-6dbd6a059fa10",
                column: "UserType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-47ad-8b36-6dbd6a059fa4",
                column: "UserType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-48ad-8b36-6dbd6a059fa5",
                column: "UserType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-57ad-8b36-6dbd6a057fa9",
                column: "UserType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-67ad-8b36-6dbd6a059fa6",
                column: "UserType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f04028e-587c-77ad-8b36-6dbd6a059fa8",
                column: "UserType",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c542843d-26f3-4713-8f38-93294bbb509b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "a077af14-7529-435a-a102-f46cd07fd9fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "ef7ef5d7-a28e-4192-98c1-501865d7f5c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7213",
                column: "ConcurrencyStamp",
                value: "91b1099a-e808-4538-9db2-4d961ae42d5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7214",
                column: "ConcurrencyStamp",
                value: "5e5f351c-cf9f-4af2-abf7-fcd303543015");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7215",
                column: "ConcurrencyStamp",
                value: "dd88c095-0362-46fc-8258-ec3a0129d474");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7216",
                column: "ConcurrencyStamp",
                value: "030621fb-d183-4635-ac74-85b15c47e53c");
        }
    }
}
