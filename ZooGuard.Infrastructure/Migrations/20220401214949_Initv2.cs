using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooGuard.Infrastructure.Migrations
{
    public partial class Initv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "42056a33-660b-4eb4-9c14-e9184a23a0ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37f3e0b3-08fa-4837-b4a8-1d3ac8907566", "AQAAAAEAACcQAAAAEOwOn15laKGqVH87GTRVFj/ZxmSbdLdHeuGHRcggjPqKpGciGREGwoIDTGt0UQKBDw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "b4a80cdc-6c46-472d-8843-e9ba9f976697");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "475a93d9-e0fa-4a4a-a376-366f2ac9ed3d", "AQAAAAEAACcQAAAAEJGVeRoRDlV5CdJuQrnWqeDcwtCTEG9U3cvoglV8ihSZFb2i5LUPeQo28PoJ/LvHzw==" });
        }
    }
}
