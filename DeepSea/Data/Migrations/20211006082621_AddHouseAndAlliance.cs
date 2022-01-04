using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class AddHouseAndAlliance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Alliance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alliance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllianceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                    table.ForeignKey(
                        name: "FK_House_Alliance_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HouseId",
                table: "AspNetUsers",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_House_AllianceId",
                table: "House",
                column: "AllianceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_House_HouseId",
                table: "AspNetUsers",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_House_HouseId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "House");

            migrationBuilder.DropTable(
                name: "Alliance");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HouseId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "AspNetUsers");

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
    }
}
