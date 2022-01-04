using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class addTeamUserUnitDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamUsersUnitDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamUsersId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamUsersUnitDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamUsersUnitDetail_TeamUsers_TeamUsersId",
                        column: x => x.TeamUsersId,
                        principalTable: "TeamUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamUsersUnitDetail_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamUsersUnitDetail_TeamUsersId",
                table: "TeamUsersUnitDetail",
                column: "TeamUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamUsersUnitDetail_UnitId",
                table: "TeamUsersUnitDetail",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamUsersUnitDetail");
        }
    }
}
