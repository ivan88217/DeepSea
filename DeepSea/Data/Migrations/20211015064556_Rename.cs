using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseMemberDeatil_Alliance_AllianceId",
                table: "HouseMemberDeatil");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseMemberDeatil_House_HouseId",
                table: "HouseMemberDeatil");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseMemberDeatil_HouseMember_HouseMemberId",
                table: "HouseMemberDeatil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseMemberDeatil",
                table: "HouseMemberDeatil");

            migrationBuilder.RenameTable(
                name: "HouseMemberDeatil",
                newName: "HouseMemberDetail");

            migrationBuilder.RenameIndex(
                name: "IX_HouseMemberDeatil_HouseMemberId",
                table: "HouseMemberDetail",
                newName: "IX_HouseMemberDetail_HouseMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_HouseMemberDeatil_HouseId",
                table: "HouseMemberDetail",
                newName: "IX_HouseMemberDetail_HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_HouseMemberDeatil_AllianceId",
                table: "HouseMemberDetail",
                newName: "IX_HouseMemberDetail_AllianceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseMemberDetail",
                table: "HouseMemberDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseMemberDetail_Alliance_AllianceId",
                table: "HouseMemberDetail",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseMemberDetail_House_HouseId",
                table: "HouseMemberDetail",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseMemberDetail_HouseMember_HouseMemberId",
                table: "HouseMemberDetail",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HouseMemberDetail_Alliance_AllianceId",
                table: "HouseMemberDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseMemberDetail_House_HouseId",
                table: "HouseMemberDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseMemberDetail_HouseMember_HouseMemberId",
                table: "HouseMemberDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseMemberDetail",
                table: "HouseMemberDetail");

            migrationBuilder.RenameTable(
                name: "HouseMemberDetail",
                newName: "HouseMemberDeatil");

            migrationBuilder.RenameIndex(
                name: "IX_HouseMemberDetail_HouseMemberId",
                table: "HouseMemberDeatil",
                newName: "IX_HouseMemberDeatil_HouseMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_HouseMemberDetail_HouseId",
                table: "HouseMemberDeatil",
                newName: "IX_HouseMemberDeatil_HouseId");

            migrationBuilder.RenameIndex(
                name: "IX_HouseMemberDetail_AllianceId",
                table: "HouseMemberDeatil",
                newName: "IX_HouseMemberDeatil_AllianceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseMemberDeatil",
                table: "HouseMemberDeatil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseMemberDeatil_Alliance_AllianceId",
                table: "HouseMemberDeatil",
                column: "AllianceId",
                principalTable: "Alliance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseMemberDeatil_House_HouseId",
                table: "HouseMemberDeatil",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HouseMemberDeatil_HouseMember_HouseMemberId",
                table: "HouseMemberDeatil",
                column: "HouseMemberId",
                principalTable: "HouseMember",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
