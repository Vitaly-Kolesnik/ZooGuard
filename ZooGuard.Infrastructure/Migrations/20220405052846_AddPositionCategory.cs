using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class AddPositionCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Positions",
                newName: "ShortName");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Positions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PositionCategoryId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PositionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionCategories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ec75286c-2956-4cd0-a051-d4a592084480");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55e1f178-2d67-41f8-b9bd-f6292c90ce5c", "AQAAAAEAACcQAAAAEH6qeFYLPiBCxZ0QAHD2HXMcU3KYiBxDZd3nlfwZkXA3LPMMAlsCyTQhkYJjZL9Qbg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PositionCategoryId",
                table: "Positions",
                column: "PositionCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_PositionCategories_PositionCategoryId",
                table: "Positions",
                column: "PositionCategoryId",
                principalTable: "PositionCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_PositionCategories_PositionCategoryId",
                table: "Positions");

            migrationBuilder.DropTable(
                name: "PositionCategories");

            migrationBuilder.DropIndex(
                name: "IX_Positions_PositionCategoryId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionCategoryId",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "Positions",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "d97dbcbe-c7a5-46e8-bcc6-5e325fcc2abd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69ddb4a0-cfd9-43dc-a21f-6c88324e489f", "AQAAAAEAACcQAAAAEBki4ey/0HVw8jM5tbhGr9iqXSEqUGbuqljkBZ5TlZxlosS8rnWS5CXDqxvcKTyy0Q==" });
        }
    }
}
