using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartSchool.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SavingEnumAsStringsAndSeedStudentAndTeacherTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CourseType",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                column: "CourseType",
                value: "Regular");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                column: "CourseType",
                value: "Optional");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1001,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1002,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1003,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1004,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1005,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1006,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1007,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1008,
                column: "RoomType",
                value: "ClassRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2001,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2002,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2003,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2004,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2005,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2006,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2007,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2008,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2009,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2010,
                column: "RoomType",
                value: "TeacherRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 3001,
                column: "RoomType",
                value: "CommonRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 3002,
                column: "RoomType",
                value: "CommonRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 4001,
                column: "RoomType",
                value: "SeminarRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 5001,
                column: "RoomType",
                value: "MeetingRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 6001,
                column: "RoomType",
                value: "SportsRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 6002,
                column: "RoomType",
                value: "SportsRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 7001,
                column: "RoomType",
                value: "RegisterRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 8001,
                column: "RoomType",
                value: "StoreRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 9001,
                column: "RoomType",
                value: "StaffRoom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 9002,
                column: "RoomType",
                value: "StaffRoom");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassLevelNumber", "CreatedDate", "DateOfBirth", "Gender", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Dhaka", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Asif", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Gazipur", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Hinata", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Dhaka", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Naruto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Gazipur", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Sakura", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Dhaka", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Neji", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Gazipur", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Rock Lee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Dhaka", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Shikamaru", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Gazipur", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Choji", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Dhaka", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Kiba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Gazipur", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Akamaru", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Dhaka", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Ino", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Gazipur", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Suske", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Dhaka", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Gaara", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Gazipur", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Temari", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Dhaka", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Male", "Kankuro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Gazipur", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Female", "Konohamaru", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Address", "CreatedDate", "DateOfBirth", "Designation", "Gender", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Professor", "Male", "Jiraiya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Professor", "Female", "Tsunade", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Professor", "Male", "Hiruzen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Professor", "Female", "Minato", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssociateProfessor", "Male", "Kahashi Sensei", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssociateProfessor", "Female", "Yamato", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssociateProfessor", "Male", "Might Guy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssociateProfessor", "Female", "Asuma", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssistantProfessor", "Male", "Orochimaru", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssistantProfessor", "Female", "Nagato", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssistantProfessor", "Male", "Yahiko", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "AssistantProfessor", "Female", "Kisame", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Lecturer", "Male", "Iruka Sensei", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Lecturer", "Female", "Itachi Uchiha", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Dhaka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Lecturer", "Male", "Deridara", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Gazipur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 1, 20), "Lecturer", "Female", "Tobi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Teachers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Designation",
                table: "Teachers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RoomType",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CourseType",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1001,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1002,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1003,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1004,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1005,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1006,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1007,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 1008,
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2001,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2002,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2003,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2004,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2005,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2006,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2007,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2008,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2009,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 2010,
                column: "RoomType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 3001,
                column: "RoomType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 3002,
                column: "RoomType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 4001,
                column: "RoomType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 5001,
                column: "RoomType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 6001,
                column: "RoomType",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 6002,
                column: "RoomType",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 7001,
                column: "RoomType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 8001,
                column: "RoomType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 9001,
                column: "RoomType",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomNumber",
                keyValue: 9002,
                column: "RoomType",
                value: 8);
        }
    }
}
