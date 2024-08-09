using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartSchool.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoomTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomNumber);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomNumber", "Capacity", "Description", "IsAvailable", "RoomType" },
                values: new object[,]
                {
                    { 1001, 50, "Room for Class One", true, 0 },
                    { 1002, 50, "Room for Class Two", true, 0 },
                    { 1003, 50, "Room for Class Three", true, 0 },
                    { 1004, 50, "Room for Class Four", true, 0 },
                    { 1005, 50, "Room for Class Five", true, 0 },
                    { 1006, 50, "Room for Class Six", true, 0 },
                    { 1007, 50, "Room for Class Seven", true, 0 },
                    { 1008, 50, "Room for Class Eight", true, 0 },
                    { 2001, 1, "Room for Teachers 2001", true, 5 },
                    { 2002, 1, "Room for Teachers 2002", true, 5 },
                    { 2003, 1, "Room for Teachers 2003", true, 5 },
                    { 2004, 1, "Room for Teachers 2004", true, 5 },
                    { 2005, 1, "Room for Teachers 2005", true, 5 },
                    { 2006, 1, "Room for Teachers 2006", true, 5 },
                    { 2007, 1, "Room for Teachers 2007", true, 5 },
                    { 2008, 1, "Room for Teachers 2008", true, 5 },
                    { 2009, 1, "Room for Teachers 2009", true, 5 },
                    { 2010, 1, "Room for Teachers 2010", true, 5 },
                    { 3001, 50, "Common Room", true, 3 },
                    { 3002, 50, "Common Room", true, 3 },
                    { 4001, 300, "Seminar Room", true, 1 },
                    { 5001, 50, "Meeting Room for Teachers", true, 2 },
                    { 6001, 100, "Sports Room", true, 7 },
                    { 6002, 100, "Sports Room", true, 7 },
                    { 7001, 10, "Register Room", true, 4 },
                    { 8001, 100, "Store Room", true, 6 },
                    { 9001, 10, "Staff Room", true, 8 },
                    { 9002, 10, "Staff Room", true, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
