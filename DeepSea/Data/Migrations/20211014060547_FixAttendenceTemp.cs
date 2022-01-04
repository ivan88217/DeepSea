using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class FixAttendenceTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId1",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId1",
                table: "AttendenceTempRecord");

            migrationBuilder.DropColumn(
                name: "HouseMemberId1",
                table: "AttendenceTempRecord");

            migrationBuilder.AlterColumn<int>(
                name: "HouseMemberId",
                table: "AttendenceTempRecord",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord",
                column: "HouseMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId",
                table: "AttendenceTempRecord",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord");

            migrationBuilder.AlterColumn<string>(
                name: "HouseMemberId",
                table: "AttendenceTempRecord",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "HouseMemberId1",
                table: "AttendenceTempRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId1",
                table: "AttendenceTempRecord",
                column: "HouseMemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId1",
                table: "AttendenceTempRecord",
                column: "HouseMemberId1",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
