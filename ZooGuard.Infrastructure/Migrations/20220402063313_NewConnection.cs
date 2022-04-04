using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerRooms_Organisations_OrganisationId",
                table: "ServerRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Organisations_OrganisationId",
                table: "Storages");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationId",
                table: "Storages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationId",
                table: "ServerRooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ServerRooms_Organisations_OrganisationId",
                table: "ServerRooms",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Organisations_OrganisationId",
                table: "Storages",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerRooms_Organisations_OrganisationId",
                table: "ServerRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Organisations_OrganisationId",
                table: "Storages");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationId",
                table: "Storages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationId",
                table: "ServerRooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "42056a33-660b-4eb4-9c14-e9184a23a0ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37f3e0b3-08fa-4837-b4a8-1d3ac8907566", "AQAAAAEAACcQAAAAEOwOn15laKGqVH87GTRVFj/ZxmSbdLdHeuGHRcggjPqKpGciGREGwoIDTGt0UQKBDw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ServerRooms_Organisations_OrganisationId",
                table: "ServerRooms",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Organisations_OrganisationId",
                table: "Storages",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
