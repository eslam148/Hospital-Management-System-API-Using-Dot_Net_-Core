using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class modifiy3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Hospitals_Hospitalsid",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Hospitalsid",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03b8930c-0e7d-49e1-8881-9a2d8c408720");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f031cee-760b-4c7a-947d-ec7ceb4e14a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "373aace4-f0d4-4854-aa74-f9abe93c0a7f");

            migrationBuilder.DropColumn(
                name: "Hospitalsid",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6206e8c4-10ad-4ab6-9e68-95fb8ca8f0fd", null, "Nurse", "NURSE" },
                    { "b6c6eff9-c110-45dc-a7bf-f476960be6c8", null, "Receptionist", "RECEPTIONIST" },
                    { "efdee878-4f17-4165-8161-a78d274bc851", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HospitalId",
                table: "Departments",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Hospitals_HospitalId",
                table: "Departments",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Hospitals_HospitalId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_HospitalId",
                table: "Departments");

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

            migrationBuilder.AlterColumn<string>(
                name: "HospitalId",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Hospitalsid",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03b8930c-0e7d-49e1-8881-9a2d8c408720", null, "Doctor", "DOCTOR" },
                    { "1f031cee-760b-4c7a-947d-ec7ceb4e14a5", null, "Receptionist", "RECEPTIONIST" },
                    { "373aace4-f0d4-4854-aa74-f9abe93c0a7f", null, "Nurse", "NURSE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Hospitalsid",
                table: "Departments",
                column: "Hospitalsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Hospitals_Hospitalsid",
                table: "Departments",
                column: "Hospitalsid",
                principalTable: "Hospitals",
                principalColumn: "id");
        }
    }
}
