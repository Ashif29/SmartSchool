using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSchool.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassLevelNumber",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassLevelNumber",
                table: "Courses",
                column: "ClassLevelNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassLevels_ClassLevelNumber",
                table: "Courses",
                column: "ClassLevelNumber",
                principalTable: "ClassLevels",
                principalColumn: "LevelNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassLevels_ClassLevelNumber",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ClassLevelNumber",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ClassLevelNumber",
                table: "Courses");
        }
    }
}
