using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomMod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24e99d2a-fbd8-4ccd-8715-52695c562756", null, "Doctor", "DOCTOR" },
                    { "876964ca-2f5d-4190-bee8-2b08a7bfd616", null, "Nurse", "NURSE" },
                    { "ab9045bf-6c5a-4f86-b12d-07325bdee51f", null, "Receptionist", "RECEPTIONIST" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24e99d2a-fbd8-4ccd-8715-52695c562756");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "876964ca-2f5d-4190-bee8-2b08a7bfd616");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab9045bf-6c5a-4f86-b12d-07325bdee51f");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Rooms");

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
    }
}
