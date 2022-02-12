using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class wideVender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "MailingAddress",
                table: "Venders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Сomment",
                table: "Venders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailingAddress",
                table: "Venders");

            migrationBuilder.DropColumn(
                name: "Сomment",
                table: "Venders");

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
    }
}
