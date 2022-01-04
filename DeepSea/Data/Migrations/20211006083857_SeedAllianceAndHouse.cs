using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class SeedAllianceAndHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Alliance",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "3公分" });

            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "Id", "AllianceId", "Name" },
                values: new object[] { 1, 1, "3cm感謝祭" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "House",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alliance",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
