using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class modifiy4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6206e8c4-10ad-4ab6-9e68-95fb8ca8f0fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6c6eff9-c110-45dc-a7bf-f476960be6c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efdee878-4f17-4165-8161-a78d274bc851");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4308670d-64f6-4134-8fb0-95a598c6beea", null, "Doctor", "DOCTOR" },
                    { "8b68d653-9c47-41c8-bc13-8b3e72adbc1d", null, "Nurse", "NURSE" },
                    { "c79cc848-0bb7-495f-8924-8d2c5bcfdc34", null, "Receptionist", "RECEPTIONIST" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4308670d-64f6-4134-8fb0-95a598c6beea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b68d653-9c47-41c8-bc13-8b3e72adbc1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c79cc848-0bb7-495f-8924-8d2c5bcfdc34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6206e8c4-10ad-4ab6-9e68-95fb8ca8f0fd", null, "Nurse", "NURSE" },
                    { "b6c6eff9-c110-45dc-a7bf-f476960be6c8", null, "Receptionist", "RECEPTIONIST" },
                    { "efdee878-4f17-4165-8161-a78d274bc851", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
