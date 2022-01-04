using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepSea.Data.Migrations
{
    public partial class UpdateUserOwnUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "MemberOwnUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CurrentLevel",
                table: "MemberOwnUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasDecrease",
                table: "MemberOwnUnits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "AttendenceTempRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseMemberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseMemberId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendenceTempRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendenceTempRecord_HouseMember_HouseMemberId1",
                        column: x => x.HouseMemberId1,
                        principalTable: "HouseMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceTempRecord_HouseMemberId1",
                table: "AttendenceTempRecord",
                column: "HouseMemberId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendenceTempRecord");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "MemberOwnUnits");

            migrationBuilder.DropColumn(
                name: "CurrentLevel",
                table: "MemberOwnUnits");

            migrationBuilder.DropColumn(
                name: "HasDecrease",
                table: "MemberOwnUnits");
        }
    }
}
