using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewStorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "ActualAddress",
                table: "Places",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Characteristic",
                table: "Places",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Places",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualAddress",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Characteristic",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Places",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "40518b04-1512-40a8-aee1-021911c94dac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f634ab6c-f96f-49fc-b720-88d3b3fd07ab", "AQAAAAEAACcQAAAAELZrB8zJ9P2cyf4OexIvWhW5IJ5CuGSuonTfXgAFO8AHLtVDJxf9PqTYQQWGNsnY1g==" });
        }
    }
}
