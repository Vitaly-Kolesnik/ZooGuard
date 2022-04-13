using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class fullmigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInCompanies_Companies_CompanyId",
                table: "WorkersInCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInCompanies_Workers_WorkerId",
                table: "WorkersInCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersInCompanies",
                table: "WorkersInCompanies");

            migrationBuilder.RenameTable(
                name: "WorkersInCompanies",
                newName: "WorkersInCompany");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersInCompanies_CompanyId",
                table: "WorkersInCompany",
                newName: "IX_WorkersInCompany_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersInCompany",
                table: "WorkersInCompany",
                columns: new[] { "WorkerId", "CompanyId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "984c99af-0acc-4cff-bff2-f2861cbf79c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02246753-7a69-4c5a-86f3-ddddb76a6e52", "AQAAAAEAACcQAAAAEF4O4bCS8hLpTQvIkYb8RNx0IS7fYlAlxqcFDZwtMKo9LSnhdG3j98qedmipj3dbuA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInCompany_Companies_CompanyId",
                table: "WorkersInCompany",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInCompany_Workers_WorkerId",
                table: "WorkersInCompany",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInCompany_Companies_CompanyId",
                table: "WorkersInCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInCompany_Workers_WorkerId",
                table: "WorkersInCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersInCompany",
                table: "WorkersInCompany");

            migrationBuilder.RenameTable(
                name: "WorkersInCompany",
                newName: "WorkersInCompanies");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersInCompany_CompanyId",
                table: "WorkersInCompanies",
                newName: "IX_WorkersInCompanies_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersInCompanies",
                table: "WorkersInCompanies",
                columns: new[] { "WorkerId", "CompanyId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "05e0c843-db7d-4e25-8c15-53f1d3765f22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d065cd6-2c99-4585-a335-ed6dcf3926e2", "AQAAAAEAACcQAAAAEJaqHsXXLkPqmfzdh2u6EzhWt5Rf9s48g2On88e0g5ahJWmOTSVyDCuUZoMnWUGEQQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInCompanies_Companies_CompanyId",
                table: "WorkersInCompanies",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInCompanies_Workers_WorkerId",
                table: "WorkersInCompanies",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
