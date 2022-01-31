using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormOfOccurences_Positions_PositionId",
                table: "FormOfOccurences");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerPositions_Positions_PositionId",
                table: "OwnerPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusLabels_Positions_PositionId",
                table: "StatusLabels");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_StatusLabels_StatusLabelId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_StatusLabelId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_OwnerPositions_PositionId",
                table: "OwnerPositions");

            migrationBuilder.DropIndex(
                name: "IX_FormOfOccurences_PositionId",
                table: "FormOfOccurences");

            migrationBuilder.DropColumn(
                name: "StatusLabelId",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "NameStorage",
                table: "StatusLabels");

            migrationBuilder.DropColumn(
                name: "NameFormOfOccurence",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "NameOwnerPosition",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "NameStatusLabel",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "NameUser",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "OwnerPositions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "FormOfOccurences");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "StatusLabels",
                newName: "StorageId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusLabels_PositionId",
                table: "StatusLabels",
                newName: "IX_StatusLabels_StorageId");

            migrationBuilder.AddColumn<int>(
                name: "FormOfOccurenceId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerPositionId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusLabelId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_FormOfOccurenceId",
                table: "Positions",
                column: "FormOfOccurenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_OwnerPositionId",
                table: "Positions",
                column: "OwnerPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_StatusLabelId",
                table: "Positions",
                column: "StatusLabelId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_StatusLabels_Storages_StorageId",
                table: "StatusLabels",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_StatusLabels_Storages_StorageId",
                table: "StatusLabels");

            migrationBuilder.DropIndex(
                name: "IX_Positions_FormOfOccurenceId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_OwnerPositionId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_StatusLabelId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "FormOfOccurenceId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "OwnerPositionId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "StatusLabelId",
                table: "Positions");

            migrationBuilder.RenameColumn(
                name: "StorageId",
                table: "StatusLabels",
                newName: "PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusLabels_StorageId",
                table: "StatusLabels",
                newName: "IX_StatusLabels_PositionId");

            migrationBuilder.AddColumn<int>(
                name: "StatusLabelId",
                table: "Storages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameStorage",
                table: "StatusLabels",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameFormOfOccurence",
                table: "Positions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameOwnerPosition",
                table: "Positions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NameStatusLabel",
                table: "Positions",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameUser",
                table: "Positions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "OwnerPositions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "FormOfOccurences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_StatusLabelId",
                table: "Storages",
                column: "StatusLabelId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerPositions_PositionId",
                table: "OwnerPositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormOfOccurences_PositionId",
                table: "FormOfOccurences",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormOfOccurences_Positions_PositionId",
                table: "FormOfOccurences",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerPositions_Positions_PositionId",
                table: "OwnerPositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusLabels_Positions_PositionId",
                table: "StatusLabels",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_StatusLabels_StatusLabelId",
                table: "Storages",
                column: "StatusLabelId",
                principalTable: "StatusLabels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
