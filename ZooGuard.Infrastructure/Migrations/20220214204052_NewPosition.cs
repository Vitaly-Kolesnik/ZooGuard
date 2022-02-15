using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Positions_PositionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Storages_StorageId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Users_UserId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Venders_VenderId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_PositionId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdInformationAboutPosition",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdStorage",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "RealityFlag",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "IdVender",
                table: "Positions",
                newName: "InformationAboutPositionId");

            migrationBuilder.AlterColumn<int>(
                name: "VenderId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StorageId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Storages_StorageId",
                table: "Positions",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Users_UserId",
                table: "Positions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Venders_VenderId",
                table: "Positions",
                column: "VenderId",
                principalTable: "Venders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Storages_StorageId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Users_UserId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Venders_VenderId",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "InformationAboutPositionId",
                table: "Positions",
                newName: "IdVender");

            migrationBuilder.AlterColumn<int>(
                name: "VenderId",
                table: "Positions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Positions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StorageId",
                table: "Positions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdInformationAboutPosition",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdStorage",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RealityFlag",
                table: "Positions",
                type: "bit",
                maxLength: 1,
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PositionId",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Positions_PositionId",
                table: "Positions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Storages_StorageId",
                table: "Positions",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Users_UserId",
                table: "Positions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Venders_VenderId",
                table: "Positions",
                column: "VenderId",
                principalTable: "Venders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
