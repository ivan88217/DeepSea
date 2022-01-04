using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class TeamAddHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Team",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Team_HouseId",
                table: "Team",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_House_HouseId",
                table: "Team",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_House_HouseId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_HouseId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Team");
        }
    }
}
