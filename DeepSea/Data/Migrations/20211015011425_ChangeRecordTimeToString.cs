using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class ChangeRecordTimeToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceRecordDetail_HouseMemberId",
                table: "AttendenceRecordDetail");

            migrationBuilder.AlterColumn<string>(
                name: "RecordTime",
                table: "AttendenceRecord",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord",
                column: "HouseMemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceRecordDetail_HouseMemberId",
                table: "AttendenceRecordDetail",
                column: "HouseMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceRecordDetail_HouseMemberId",
                table: "AttendenceRecordDetail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordTime",
                table: "AttendenceRecord",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord",
                column: "HouseMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceRecordDetail_HouseMemberId",
                table: "AttendenceRecordDetail",
                column: "HouseMemberId",
                unique: true);
        }
    }
}
