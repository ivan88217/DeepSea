using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class TempAddAllience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllianceId",
                table: "AttendenceTempRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_AllianceId",
                table: "AttendenceTempRecord",
                column: "AllianceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceTempRecord_Alliance_AllianceId",
                table: "AttendenceTempRecord",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_Alliance_AllianceId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_AllianceId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropColumn(
                name: "AllianceId",
                table: "AttendenceTempRecord");
        }
    }
}
