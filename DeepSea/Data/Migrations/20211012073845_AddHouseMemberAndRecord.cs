using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class AddHouseMemberAndRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseMemberId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AttendenceRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendenceRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseMember", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttendenceRecordDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendenceRecordId = table.Column<int>(type: "int", nullable: false),
                    HouseMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendenceRecordDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendenceRecordDetail_AttendenceRecord_AttendenceRecordId",
                        column: x => x.AttendenceRecordId,
                        principalTable: "AttendenceRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendenceRecordDetail_HouseMember_HouseMemberId",
                        column: x => x.HouseMemberId,
                        principalTable: "HouseMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HouseMemberId",
                table: "AspNetUsers",
                column: "HouseMemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceRecordDetail_AttendenceRecordId",
                table: "AttendenceRecordDetail",
                column: "AttendenceRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceRecordDetail_HouseMemberId",
                table: "AttendenceRecordDetail",
                column: "HouseMemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_HouseMember_HouseMemberId",
                table: "AspNetUsers",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_HouseMember_HouseMemberId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AttendenceRecordDetail");

            migrationBuilder.DropTable(
                name: "AttendenceRecord");

            migrationBuilder.DropTable(
                name: "HouseMember");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_HouseMemberId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HouseMemberId",
                table: "AspNetUsers");
        }
    }
}
