using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPosition_OwnerPositionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPosition_StorageId",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "OwnerPositionId",
                table: "Positions",
                newName: "VenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_OwnerPositionId",
                table: "Positions",
                newName: "IX_Positions_VenderId");

            migrationBuilder.AddColumn<int>(
                name: "IdStorage",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVender",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActualAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VirtualAdress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailForSupport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstNameRepresentative = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastNameRepresentative = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneRepresentative = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EmailRepresentative = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venders", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Storages_StorageId",
                table: "Positions",
                column: "StorageId",
                principalTable: "Storages",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Storages_StorageId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Venders_VenderId",
                table: "Positions");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Venders");

            migrationBuilder.DropColumn(
                name: "IdStorage",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdVender",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "VenderId",
                table: "Positions",
                newName: "OwnerPositionId");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_VenderId",
                table: "Positions",
                newName: "IX_Positions_OwnerPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPosition_OwnerPositionId",
                table: "Positions",
                column: "OwnerPositionId",
                principalTable: "InformationAboutPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPosition_StorageId",
                table: "Positions",
                column: "StorageId",
                principalTable: "InformationAboutPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
