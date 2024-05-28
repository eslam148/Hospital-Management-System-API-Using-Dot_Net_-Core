using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class modifiy2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients");

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

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03b8930c-0e7d-49e1-8881-9a2d8c408720", null, "Doctor", "DOCTOR" },
                    { "1f031cee-760b-4c7a-947d-ec7ceb4e14a5", null, "Receptionist", "RECEPTIONIST" },
                    { "373aace4-f0d4-4854-aa74-f9abe93c0a7f", null, "Nurse", "NURSE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients");

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

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a0790ad-17f0-47b1-8186-f7f2590e84d5", null, "Doctor", "DOCTOR" },
                    { "85f18674-5f89-4652-a394-fbc29ee56fef", null, "Receptionist", "RECEPTIONIST" },
                    { "95b649e8-5e5b-41b7-a1e9-404fd752c278", null, "Nurse", "NURSE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
