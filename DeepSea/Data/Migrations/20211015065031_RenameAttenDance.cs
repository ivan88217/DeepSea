using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class RenameAttenDance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceRecord_Alliance_AllianceId",
                table: "AttendenceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceRecordDetail_AttendenceRecord_AttendenceRecordId",
                table: "AttendenceRecordDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceRecordDetail_HouseMember_HouseMemberId",
                table: "AttendenceRecordDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_Alliance_AllianceId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendenceTempRecord",
                table: "AttendenceTempRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendenceRecordDetail",
                table: "AttendenceRecordDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendenceRecord",
                table: "AttendenceRecord");

            migrationBuilder.RenameTable(
                name: "AttendenceTempRecord",
                newName: "AttendanceTempRecord");

            migrationBuilder.RenameTable(
                name: "AttendenceRecordDetail",
                newName: "AttendanceRecordDetail");

            migrationBuilder.RenameTable(
                name: "AttendenceRecord",
                newName: "AttendanceRecord");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId",
                table: "AttendanceTempRecord",
                newName: "IX_AttendanceTempRecord_HouseMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceTempRecord_AllianceId",
                table: "AttendanceTempRecord",
                newName: "IX_AttendanceTempRecord_AllianceId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceRecordDetail_HouseMemberId",
                table: "AttendanceRecordDetail",
                newName: "IX_AttendanceRecordDetail_HouseMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceRecordDetail_AttendenceRecordId",
                table: "AttendanceRecordDetail",
                newName: "IX_AttendanceRecordDetail_AttendenceRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceRecord_AllianceId",
                table: "AttendanceRecord",
                newName: "IX_AttendanceRecord_AllianceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendanceTempRecord",
                table: "AttendanceTempRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendanceRecordDetail",
                table: "AttendanceRecordDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendanceRecord",
                table: "AttendanceRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecord_Alliance_AllianceId",
                table: "AttendanceRecord",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecordDetail_AttendanceRecord_AttendenceRecordId",
                table: "AttendanceRecordDetail",
                column: "AttendenceRecordId",
                principalTable: "AttendanceRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecordDetail_HouseMember_HouseMemberId",
                table: "AttendanceRecordDetail",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceTempRecord_Alliance_AllianceId",
                table: "AttendanceTempRecord",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceTempRecord_HouseMember_HouseMemberId",
                table: "AttendanceTempRecord",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRecord_Alliance_AllianceId",
                table: "AttendanceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRecordDetail_AttendanceRecord_AttendenceRecordId",
                table: "AttendanceRecordDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRecordDetail_HouseMember_HouseMemberId",
                table: "AttendanceRecordDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceTempRecord_Alliance_AllianceId",
                table: "AttendanceTempRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceTempRecord_HouseMember_HouseMemberId",
                table: "AttendanceTempRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendanceTempRecord",
                table: "AttendanceTempRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendanceRecordDetail",
                table: "AttendanceRecordDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendanceRecord",
                table: "AttendanceRecord");

            migrationBuilder.RenameTable(
                name: "AttendanceTempRecord",
                newName: "AttendenceTempRecord");

            migrationBuilder.RenameTable(
                name: "AttendanceRecordDetail",
                newName: "AttendenceRecordDetail");

            migrationBuilder.RenameTable(
                name: "AttendanceRecord",
                newName: "AttendenceRecord");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceTempRecord_HouseMemberId",
                table: "AttendenceTempRecord",
                newName: "IX_AttendenceTempRecord_HouseMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceTempRecord_AllianceId",
                table: "AttendenceTempRecord",
                newName: "IX_AttendenceTempRecord_AllianceId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceRecordDetail_HouseMemberId",
                table: "AttendenceRecordDetail",
                newName: "IX_AttendenceRecordDetail_HouseMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceRecordDetail_AttendenceRecordId",
                table: "AttendenceRecordDetail",
                newName: "IX_AttendenceRecordDetail_AttendenceRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceRecord_AllianceId",
                table: "AttendenceRecord",
                newName: "IX_AttendenceRecord_AllianceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendenceTempRecord",
                table: "AttendenceTempRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendenceRecordDetail",
                table: "AttendenceRecordDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendenceRecord",
                table: "AttendenceRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceRecord_Alliance_AllianceId",
                table: "AttendenceRecord",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceRecordDetail_AttendenceRecord_AttendenceRecordId",
                table: "AttendenceRecordDetail",
                column: "AttendenceRecordId",
                principalTable: "AttendenceRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceRecordDetail_HouseMember_HouseMemberId",
                table: "AttendenceRecordDetail",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceTempRecord_Alliance_AllianceId",
                table: "AttendenceTempRecord",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId",
                table: "AttendenceTempRecord",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
