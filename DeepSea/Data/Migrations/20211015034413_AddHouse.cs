using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class AddHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "AttendenceTempRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "AttendenceRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseId",
                table: "AttendenceTempRecord",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceRecord_HouseId",
                table: "AttendenceRecord",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceRecord_House_HouseId",
                table: "AttendenceRecord",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceTempRecord_House_HouseId",
                table: "AttendenceTempRecord",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceRecord_House_HouseId",
                table: "AttendenceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_House_HouseId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_HouseId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceRecord_HouseId",
                table: "AttendenceRecord");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "AttendenceRecord");
        }
    }
}
