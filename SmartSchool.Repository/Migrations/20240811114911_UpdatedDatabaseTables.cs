using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSchool.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDatabaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTaken",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "IsTaken", "TeacherId" },
                values: new object[] { false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsTaken",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Courses");
        }
    }
}
