using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class addsu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c14e62c0-1c97-4940-ad61-aeb233b2e4e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2b56a32-face-4de6-be61-77682b7fbfac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4b4bf30-2998-48e5-a371-5d08b0d71dc0", "67dc9b7c-cf7c-4036-98af-5d850de7c9fc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ecb0c57-0d41-49ce-bc44-aa0ec4284e1f", "1e65b2ac-e8da-4fa5-bea5-f71e0725e6a2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebc5020f-73d6-46a7-8bbd-87722ecd5714", "9f1f00d4-066d-4a6c-a014-5bfcfa4d675b", "Su", "SU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ecb0c57-0d41-49ce-bc44-aa0ec4284e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4b4bf30-2998-48e5-a371-5d08b0d71dc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc5020f-73d6-46a7-8bbd-87722ecd5714");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2b56a32-face-4de6-be61-77682b7fbfac", "d47f1baf-7642-4811-af8b-f72ce329005c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c14e62c0-1c97-4940-ad61-aeb233b2e4e9", "587962ec-d22e-4a35-820f-9b363c721cc5", "Admin", "ADMIN" });
        }
    }
}
