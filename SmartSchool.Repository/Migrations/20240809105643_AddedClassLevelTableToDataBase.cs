using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartSchool.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedClassLevelTableToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassLevel",
                columns: table => new
                {
                    LevelNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLevel", x => x.LevelNumber);
                    table.ForeignKey(
                        name: "FK_ClassLevel_Rooms_RoomNumber",
                        column: x => x.RoomNumber,
                        principalTable: "Rooms",
                        principalColumn: "RoomNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClassLevel",
                columns: new[] { "LevelNumber", "Name", "RoomNumber" },
                values: new object[,]
                {
                    { 1, "Class One", 1001 },
                    { 2, "Class Two", 1002 },
                    { 3, "Class Three", 1003 },
                    { 4, "Class Four", 1004 },
                    { 5, "Class Five", 1005 },
                    { 6, "Class Six", 1006 },
                    { 7, "Class Seven", 1007 },
                    { 8, "Class Eight", 1008 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassLevel_RoomNumber",
                table: "ClassLevel",
                column: "RoomNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassLevel");
        }
    }
}
