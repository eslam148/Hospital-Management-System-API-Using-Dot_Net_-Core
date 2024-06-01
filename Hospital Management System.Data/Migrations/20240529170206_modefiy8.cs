using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class modefiy8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Patient_Pharmacy",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "info",
                table: "Patient_Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23d966c4-aae9-4cd4-9683-ad064ebf5ab0", null, "Receptionist", "RECEPTIONIST" },
                    { "35f04188-8ebf-463f-853d-90a3425c8387", null, "Nurse", "NURSE" },
                    { "a83c25da-2ed2-4e2e-95cb-e0f466a2cffa", null, "Doctor", "DOCTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23d966c4-aae9-4cd4-9683-ad064ebf5ab0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35f04188-8ebf-463f-853d-90a3425c8387");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a83c25da-2ed2-4e2e-95cb-e0f466a2cffa");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Patient_Pharmacy");

            migrationBuilder.DropColumn(
                name: "info",
                table: "Patient_Pharmacy");

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
    }
}
