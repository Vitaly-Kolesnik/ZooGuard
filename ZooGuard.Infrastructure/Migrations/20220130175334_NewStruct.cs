using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class NewStruct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_FormOfOccurences_FormOfOccurenceId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_OwnerPositions_OwnerPositionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_StatusLabels_StatusLabelId",
                table: "Positions");

            migrationBuilder.DropTable(
                name: "FormOfOccurences");

            migrationBuilder.DropTable(
                name: "OwnerPositions");

            migrationBuilder.DropTable(
                name: "StatusLabels");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropColumn(
                name: "IdFormOfOccurence",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdOwnerPosition",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdStatusLabel",
                table: "Positions");

            migrationBuilder.AddColumn<int>(
                name: "IdInformationAboutPosition",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StorageId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InformationAboutPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OwnerPosition_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StatusLabelPos_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Storage_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAboutPositions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_StorageId",
                table: "Positions",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPositions_FormOfOccurenceId",
                table: "Positions",
                column: "FormOfOccurenceId",
                principalTable: "InformationAboutPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPositions_OwnerPositionId",
                table: "Positions",
                column: "OwnerPositionId",
                principalTable: "InformationAboutPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPositions_StatusLabelId",
                table: "Positions",
                column: "StatusLabelId",
                principalTable: "InformationAboutPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPositions_StorageId",
                table: "Positions",
                column: "StorageId",
                principalTable: "InformationAboutPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPositions_FormOfOccurenceId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPositions_OwnerPositionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPositions_StatusLabelId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPositions_StorageId",
                table: "Positions");

            migrationBuilder.DropTable(
                name: "InformationAboutPositions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_StorageId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IdInformationAboutPosition",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "Positions");

            migrationBuilder.AddColumn<int>(
                name: "IdFormOfOccurence",
                table: "Positions",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdOwnerPosition",
                table: "Positions",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdStatusLabel",
                table: "Positions",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FormOfOccurences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormOfOccurences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusLabels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtTheUserFlag = table.Column<bool>(type: "bit", maxLength: 1, nullable: false),
                    IdStorage = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLabels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusLabels_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatusLabels_StorageId",
                table: "StatusLabels",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_FormOfOccurences_FormOfOccurenceId",
                table: "Positions",
                column: "FormOfOccurenceId",
                principalTable: "FormOfOccurences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_OwnerPositions_OwnerPositionId",
                table: "Positions",
                column: "OwnerPositionId",
                principalTable: "OwnerPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_StatusLabels_StatusLabelId",
                table: "Positions",
                column: "StatusLabelId",
                principalTable: "StatusLabels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
