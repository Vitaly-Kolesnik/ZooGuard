using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class FullCore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_InformationAboutPositions",
                table: "InformationAboutPositions");

            migrationBuilder.RenameTable(
                name: "InformationAboutPositions",
                newName: "InformationAboutPosition");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InformationAboutPosition",
                table: "InformationAboutPosition",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPosition_FormOfOccurenceId",
                table: "Positions",
                column: "FormOfOccurenceId",
                principalTable: "InformationAboutPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPosition_OwnerPositionId",
                table: "Positions",
                column: "OwnerPositionId",
                principalTable: "InformationAboutPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_InformationAboutPosition_StatusLabelId",
                table: "Positions",
                column: "StatusLabelId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPosition_FormOfOccurenceId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPosition_OwnerPositionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPosition_StatusLabelId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_InformationAboutPosition_StorageId",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InformationAboutPosition",
                table: "InformationAboutPosition");

            migrationBuilder.RenameTable(
                name: "InformationAboutPosition",
                newName: "InformationAboutPositions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InformationAboutPositions",
                table: "InformationAboutPositions",
                column: "Id");

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
    }
}
