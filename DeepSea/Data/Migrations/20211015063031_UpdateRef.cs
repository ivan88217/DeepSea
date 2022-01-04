using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class UpdateRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceRecord_House_HouseId",
                table: "AttendenceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceTempRecord_House_HouseId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_House_HouseId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_AttendenceTempRecord_HouseId",
                table: "AttendenceTempRecord");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "AttendenceTempRecord");

            migrationBuilder.RenameColumn(
                name: "HouseId",
                table: "Team",
                newName: "AllianceId");

            migrationBuilder.RenameIndex(
                name: "IX_Team_HouseId",
                table: "Team",
                newName: "IX_Team_AllianceId");

            migrationBuilder.RenameColumn(
                name: "HouseId",
                table: "AttendenceRecord",
                newName: "AllianceId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceRecord_HouseId",
                table: "AttendenceRecord",
                newName: "IX_AttendenceRecord_AllianceId");

            migrationBuilder.CreateTable(
                name: "HouseMemberDeatil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllianceId = table.Column<int>(type: "int", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: true),
                    HouseMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseMemberDeatil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseMemberDeatil_Alliance_AllianceId",
                        column: x => x.AllianceId,
                        principalTable: "Alliance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseMemberDeatil_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HouseMemberDeatil_HouseMember_HouseMemberId",
                        column: x => x.HouseMemberId,
                        principalTable: "HouseMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseMemberDeatil_AllianceId",
                table: "HouseMemberDeatil",
                column: "AllianceId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseMemberDeatil_HouseId",
                table: "HouseMemberDeatil",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseMemberDeatil_HouseMemberId",
                table: "HouseMemberDeatil",
                column: "HouseMemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceRecord_Alliance_AllianceId",
                table: "AttendenceRecord",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Alliance_AllianceId",
                table: "Team",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceRecord_Alliance_AllianceId",
                table: "AttendenceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Alliance_AllianceId",
                table: "Team");

            migrationBuilder.DropTable(
                name: "HouseMemberDeatil");

            migrationBuilder.RenameColumn(
                name: "AllianceId",
                table: "Team",
                newName: "HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Team_AllianceId",
                table: "Team",
                newName: "IX_Team_HouseId");

            migrationBuilder.RenameColumn(
                name: "AllianceId",
                table: "AttendenceRecord",
                newName: "HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendenceRecord_AllianceId",
                table: "AttendenceRecord",
                newName: "IX_AttendenceRecord_HouseId");

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "AttendenceTempRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseId",
                table: "AttendenceTempRecord",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Team_House_HouseId",
                table: "Team",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
