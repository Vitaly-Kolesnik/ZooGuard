using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewStorageAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdStorage",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StorageId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_StorageId",
                table: "Users",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Storages_StorageId",
                table: "Users",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Storages_StorageId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StorageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdStorage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Users");
        }
    }
}
