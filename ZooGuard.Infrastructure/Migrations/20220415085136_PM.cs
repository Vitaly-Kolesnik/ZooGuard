using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class PM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Managers_ManagerId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ManagerId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Projects",
                newName: "PMId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "3c99c318-037d-4529-9e0d-0ff62e7432f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fab9e6e8-bfa9-4871-9a4c-34cbc2015897", "AQAAAAEAACcQAAAAECM51wSAoAC9EvDyqXB30xR1pqSaruwwpuKIRVPOO7Px81KFlxBkWnHyvHs116YeuA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PMId",
                table: "Projects",
                newName: "ManagerId");

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerForeignKey = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Workers_WorkerForeignKey",
                        column: x => x.WorkerForeignKey,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "94e45969-b01c-4db8-86d5-f06f4d9bc0e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "faa6b328-5793-4e38-876d-c27949f9309b", "AQAAAAEAACcQAAAAEGK4uk09RO88WozxFUSYGYupV1Q7GRObmjJpV9v5/yF1wmO6tYAgeDuBLWBas3BaCg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ManagerId",
                table: "Projects",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_WorkerForeignKey",
                table: "Managers",
                column: "WorkerForeignKey",
                unique: true,
                filter: "[WorkerForeignKey] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Managers_ManagerId",
                table: "Projects",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
