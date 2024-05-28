using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class modifiy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d07c020-fd48-4307-8dd4-ad90e44a8460");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50427cd6-6732-4778-a34d-96f3308d74a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d84405a-e928-4490-a0bd-bf72837f0e50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a0790ad-17f0-47b1-8186-f7f2590e84d5", null, "Doctor", "DOCTOR" },
                    { "85f18674-5f89-4652-a394-fbc29ee56fef", null, "Receptionist", "RECEPTIONIST" },
                    { "95b649e8-5e5b-41b7-a1e9-404fd752c278", null, "Nurse", "NURSE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a0790ad-17f0-47b1-8186-f7f2590e84d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85f18674-5f89-4652-a394-fbc29ee56fef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95b649e8-5e5b-41b7-a1e9-404fd752c278");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d07c020-fd48-4307-8dd4-ad90e44a8460", null, "Nurse", "NURSE" },
                    { "50427cd6-6732-4778-a34d-96f3308d74a2", null, "Receptionist", "RECEPTIONIST" },
                    { "9d84405a-e928-4490-a0bd-bf72837f0e50", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
