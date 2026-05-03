using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38f78ad1-cfd9-48bf-aa77-67ee6a6690d9", "ce724942-6e4b-4ebd-b5fc-a62bdbe15087", "User", "USER" },
                    { "a21eae04-87d7-4ba4-802e-31e8cfa3691b", "66d40f3f-6a2c-4303-968f-3e31474ae28b", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38f78ad1-cfd9-48bf-aa77-67ee6a6690d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a21eae04-87d7-4ba4-802e-31e8cfa3691b");
        }
    }
}
