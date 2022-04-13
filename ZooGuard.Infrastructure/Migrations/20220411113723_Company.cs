using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class Company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Organisations_OrganisationId",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Organisations_OrganisationId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Organisations_OrganisationId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerRooms_Organisations_OrganisationId",
                table: "ServerRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Organisations_OrganisationId",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInOrganisations_Organisations_OrganisationId",
                table: "WorkersInOrganisations");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.RenameColumn(
                name: "OrganisationId",
                table: "WorkersInOrganisations",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersInOrganisations_OrganisationId",
                table: "WorkersInOrganisations",
                newName: "IX_WorkersInOrganisations_CompanyId");

            migrationBuilder.RenameColumn(
                name: "OrganisationId",
                table: "Storages",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_OrganisationId",
                table: "Storages",
                newName: "IX_Storages_CompanyId");

            migrationBuilder.RenameColumn(
                name: "OrganisationId",
                table: "ServerRooms",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_ServerRooms_OrganisationId",
                table: "ServerRooms",
                newName: "IX_ServerRooms_CompanyId");

            migrationBuilder.RenameColumn(
                name: "OrganisationId",
                table: "Projects",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_OrganisationId",
                table: "Projects",
                newName: "IX_Projects_CompanyId");

            migrationBuilder.RenameColumn(
                name: "OrganisationId",
                table: "Positions",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_OrganisationId",
                table: "Positions",
                newName: "IX_Positions_CompanyId");

            migrationBuilder.RenameColumn(
                name: "OrganisationId",
                table: "Places",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Places_OrganisationId",
                table: "Places",
                newName: "IX_Places_CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Places",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Positions_ProjectId",
                table: "Positions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_ProjectId",
                table: "Places",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Companies_CompanyId",
                table: "Places",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Projects_ProjectId",
                table: "Places",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Companies_CompanyId",
                table: "Positions",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Projects_ProjectId",
                table: "Positions",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Companies_CompanyId",
                table: "Projects",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerRooms_Companies_CompanyId",
                table: "ServerRooms",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Companies_CompanyId",
                table: "Storages",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInOrganisations_Companies_CompanyId",
                table: "WorkersInOrganisations",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Companies_CompanyId",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Projects_ProjectId",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Companies_CompanyId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Projects_ProjectId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Companies_CompanyId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerRooms_Companies_CompanyId",
                table: "ServerRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Companies_CompanyId",
                table: "Storages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkersInOrganisations_Companies_CompanyId",
                table: "WorkersInOrganisations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Positions_ProjectId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Places_ProjectId",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Places");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "WorkersInOrganisations",
                newName: "OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkersInOrganisations_CompanyId",
                table: "WorkersInOrganisations",
                newName: "IX_WorkersInOrganisations_OrganisationId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Storages",
                newName: "OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_Storages_CompanyId",
                table: "Storages",
                newName: "IX_Storages_OrganisationId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "ServerRooms",
                newName: "OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_ServerRooms_CompanyId",
                table: "ServerRooms",
                newName: "IX_ServerRooms_OrganisationId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Projects",
                newName: "OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CompanyId",
                table: "Projects",
                newName: "IX_Projects_OrganisationId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Positions",
                newName: "OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_CompanyId",
                table: "Positions",
                newName: "IX_Positions_OrganisationId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Places",
                newName: "OrganisationId");

            migrationBuilder.RenameIndex(
                name: "IX_Places_CompanyId",
                table: "Places",
                newName: "IX_Places_OrganisationId");

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4417f5f3-90a9-4d83-a32a-748c123b5b79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab1969f6-1582-4d0b-a952-e32bcc6e0521", "AQAAAAEAACcQAAAAEBDC8PIR87aaVNguj3xBsPM2JUuE/KRGAMIfMwlphSX/msYbibC838dp4w+1rB2IAQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Organisations_OrganisationId",
                table: "Places",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Organisations_OrganisationId",
                table: "Positions",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Organisations_OrganisationId",
                table: "Projects",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerRooms_Organisations_OrganisationId",
                table: "ServerRooms",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Organisations_OrganisationId",
                table: "Storages",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersInOrganisations_Organisations_OrganisationId",
                table: "WorkersInOrganisations",
                column: "OrganisationId",
                principalTable: "Organisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
