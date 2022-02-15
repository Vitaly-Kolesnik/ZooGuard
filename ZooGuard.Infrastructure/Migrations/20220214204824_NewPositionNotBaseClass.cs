using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewPositionNotBaseClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InformationAboutPositionId",
                table: "Positions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InformationAboutPositionId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
