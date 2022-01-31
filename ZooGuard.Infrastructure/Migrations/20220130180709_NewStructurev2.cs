using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewStructurev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerPosition_Name",
                table: "InformationAboutPositions");

            migrationBuilder.DropColumn(
                name: "StatusLabelPos_Name",
                table: "InformationAboutPositions");

            migrationBuilder.DropColumn(
                name: "Storage_Name",
                table: "InformationAboutPositions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "InformationAboutPositions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "InformationAboutPositions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "OwnerPosition_Name",
                table: "InformationAboutPositions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusLabelPos_Name",
                table: "InformationAboutPositions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Storage_Name",
                table: "InformationAboutPositions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
