using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class newNameCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInOrganisations_Companies_CompanyId",
                table: "WorkersInOrganisations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInOrganisations_Workers_WorkerId",
                table: "WorkersInOrganisations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersInOrganisations",
                table: "WorkersInOrganisations");

            migrationBuilder.RenameTable(
                name: "WorkersInOrganisations",
                newName: "WorkersInCompanies");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersInOrganisations_CompanyId",
                table: "WorkersInCompanies",
                newName: "IX_WorkersInCompanies_CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Positions",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PlaceId",
                table: "Positions",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Places_PlaceId",
                table: "Positions",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Places_PlaceId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInCompanies_Companies_CompanyId",
                table: "WorkersInCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInCompanies_Workers_WorkerId",
                table: "WorkersInCompanies");

            migrationBuilder.DropIndex(
                name: "IX_Positions_PlaceId",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersInCompanies",
                table: "WorkersInCompanies");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Positions");

            migrationBuilder.RenameTable(
                name: "WorkersInCompanies",
                newName: "WorkersInOrganisations");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersInCompanies_CompanyId",
                table: "WorkersInOrganisations",
                newName: "IX_WorkersInOrganisations_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersInOrganisations",
                table: "WorkersInOrganisations",
                columns: new[] { "WorkerId", "CompanyId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "251ecda6-e6af-4769-847b-73b40c1e1468");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a80ac3a1-c454-43d9-b315-dd25f48e251d", "AQAAAAEAACcQAAAAENDKF2VGHxil/j6HO45NMfWylSP8UAj9RioEI3cMok2/a0dKQx0/uddDajJJZVRJVA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInOrganisations_Companies_CompanyId",
                table: "WorkersInOrganisations",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInOrganisations_Workers_WorkerId",
                table: "WorkersInOrganisations",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
