using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Models;
using SmartSchool.Core.Models.CourseModels;
using SmartSchool.Core.Models.RoomModels;
using SmartSchool.Core.Models.StudentModels;
using SmartSchool.Core.Models.TeacherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<ClassLevel> ClassLevels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomType).HasConversion<string>();

                // Seed Room data
                entity.HasData(
                new Room { RoomNumber = 1001, Description = "Room for Class One", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1002, Description = "Room for Class Two", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1003, Description = "Room for Class Three", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1004, Description = "Room for Class Four", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1005, Description = "Room for Class Five", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1006, Description = "Room for Class Six", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1007, Description = "Room for Class Seven", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 1008, Description = "Room for Class Eight", RoomType = RoomType.ClassRoom, IsAvailable = true, Capacity = 50 },


                new Room { RoomNumber = 2001, Description = "Room for Teachers 2001", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2002, Description = "Room for Teachers 2002", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2003, Description = "Room for Teachers 2003", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2004, Description = "Room for Teachers 2004", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2005, Description = "Room for Teachers 2005", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2006, Description = "Room for Teachers 2006", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2007, Description = "Room for Teachers 2007", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2008, Description = "Room for Teachers 2008", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2009, Description = "Room for Teachers 2009", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },
                new Room { RoomNumber = 2010, Description = "Room for Teachers 2010", RoomType = RoomType.TeacherRoom, IsAvailable = true, Capacity = 1 },

                new Room { RoomNumber = 3001, Description = "Common Room", RoomType = RoomType.CommonRoom, IsAvailable = true, Capacity = 50 },
                new Room { RoomNumber = 3002, Description = "Common Room", RoomType = RoomType.CommonRoom, IsAvailable = true, Capacity = 50 },

                new Room { RoomNumber = 4001, Description = "Seminar Room", RoomType = RoomType.SeminarRoom, IsAvailable = true, Capacity = 300 },

                new Room { RoomNumber = 5001, Description = "Meeting Room for Teachers", RoomType = RoomType.MeetingRoom, IsAvailable = true, Capacity = 50 },

                new Room { RoomNumber = 6001, Description = "Sports Room", RoomType = RoomType.SportsRoom, IsAvailable = true, Capacity = 100 },
                new Room { RoomNumber = 6002, Description = "Sports Room", RoomType = RoomType.SportsRoom, IsAvailable = true, Capacity = 100 },

                new Room { RoomNumber = 7001, Description = "Register Room", RoomType = RoomType.RegisterRoom, IsAvailable = true, Capacity = 10 },

                new Room { RoomNumber = 8001, Description = "Store Room", RoomType = RoomType.StoreRoom, IsAvailable = true, Capacity = 100 },

                new Room { RoomNumber = 9001, Description = "Staff Room", RoomType = RoomType.StaffRoom, IsAvailable = true, Capacity = 10 },
                new Room { RoomNumber = 9002, Description = "Staff Room", RoomType = RoomType.StaffRoom, IsAvailable = true, Capacity = 10 }

            );

            });

            // Seed ClassLevel data
            modelBuilder.Entity<ClassLevel>().HasData(
                new ClassLevel { LevelNumber = 1, Name = "Class One", RoomNumber = 1001 },
                new ClassLevel { LevelNumber = 2, Name = "Class Two", RoomNumber = 1002 },
                new ClassLevel { LevelNumber = 3, Name = "Class Three", RoomNumber = 1003 },
                new ClassLevel { LevelNumber = 4, Name = "Class Four", RoomNumber = 1004 },
                new ClassLevel { LevelNumber = 5, Name = "Class Five", RoomNumber = 1005 },
                new ClassLevel { LevelNumber = 6, Name = "Class Six", RoomNumber = 1006 },
                new ClassLevel { LevelNumber = 7, Name = "Class Seven", RoomNumber = 1007 },
                new ClassLevel { LevelNumber = 8, Name = "Class Eight", RoomNumber = 1008 }

            );

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseType).HasConversion<string>();

                entity.HasData(
                    new Course { Id = 1, CourseCode = "Ban-1", Name = "Bangla-I", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 1 },
                    new Course { Id = 2, CourseCode = "Eng-1", Name = "English-I", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 1 },
                    new Course { Id = 3, CourseCode = "Math-1", Name = "Mathematics-I", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 1 },
                    new Course { Id = 4, CourseCode = "Rel-1", Name = "Religion-I", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 1 },

                    new Course { Id = 5, CourseCode = "Ban-2", Name = "Bangla-II", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 2 },
                    new Course { Id = 6, CourseCode = "Eng-2", Name = "English-II", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 2 },
                    new Course { Id = 7, CourseCode = "Math-2", Name = "Mathematics-II", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 2 },
                    new Course { Id = 8, CourseCode = "Rel-2", Name = "Religion-II", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 2 },

                    new Course { Id = 9, CourseCode = "Ban-3", Name = "Bangla-III", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 3 },
                    new Course { Id = 10, CourseCode = "Eng-3", Name = "English-III", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 3 },
                    new Course { Id = 11, CourseCode = "Math-3", Name = "Mathematics-III", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 3 },
                    new Course { Id = 12, CourseCode = "Rel-3", Name = "Religion-III", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 3 },

                    new Course { Id = 13, CourseCode = "Ban-4", Name = "Bangla-IV", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 4 },
                    new Course { Id = 14, CourseCode = "Eng-4", Name = "English-IV", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 4 },
                    new Course { Id = 15, CourseCode = "Math-4", Name = "Mathematics-IV", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 4 },
                    new Course { Id = 16, CourseCode = "Rel-4", Name = "Religion-IV", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 4 },

                    new Course { Id = 17, CourseCode = "Ban-5", Name = "Bangla-V", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 5 },
                    new Course { Id = 18, CourseCode = "Eng-5", Name = "English-V", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 5 },
                    new Course { Id = 19, CourseCode = "Math-5", Name = "Mathematics-V", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 5 },
                    new Course { Id = 20, CourseCode = "Rel-5", Name = "Religion-V", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 5 },

                    new Course { Id = 21, CourseCode = "Ban-6", Name = "Bangla-VI", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 6 },
                    new Course { Id = 22, CourseCode = "Eng-6", Name = "English-VI", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 6 },
                    new Course { Id = 23, CourseCode = "Math-6", Name = "Mathematics-VI", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 6 },
                    new Course { Id = 24, CourseCode = "Rel-6", Name = "Religion-VI", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 6 },

                    new Course { Id = 25, CourseCode = "Ban-7", Name = "Bangla-VII", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 7 },
                    new Course { Id = 26, CourseCode = "Eng-7", Name = "English-VII", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 7 },
                    new Course { Id = 27, CourseCode = "Math-7", Name = "Mathematics-VII", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 7 },
                    new Course { Id = 28, CourseCode = "Rel-7", Name = "Religion-VII", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 7 },

                    new Course { Id = 29, CourseCode = "Ban-8", Name = "Bangla-VIII", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 8 },
                    new Course { Id = 30, CourseCode = "Eng-8", Name = "English-VIII", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 8 },
                    new Course { Id = 31, CourseCode = "Math-8", Name = "Mathematics-VIII", Description = "This is an regular course.", CourseType = CourseType.Regular, ClassLevelNumber = 8 },
                    new Course { Id = 32, CourseCode = "Rel-8", Name = "Religion-VIII", Description = "This is an optional course.", CourseType = CourseType.Optional, ClassLevelNumber = 8 }

                );

            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Gender).HasConversion<string>();

                entity.HasData(

                    new Student { Id = 1, Name = "Asif", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 1 },
                    new Student { Id = 2, Name = "Hinata", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 1 },
                    
                    new Student { Id = 3, Name = "Naruto", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 2 },
                    new Student { Id = 4, Name = "Sakura", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 2 },

                    new Student { Id = 5, Name = "Neji", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 3 },
                    new Student { Id = 6, Name = "Rock Lee", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 3 },

                    new Student { Id = 7, Name = "Shikamaru", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 4 },
                    new Student { Id = 8, Name = "Choji", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 4 },

                    new Student { Id = 9, Name = "Kiba", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 5 },
                    new Student { Id = 10, Name = "Akamaru", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 5 },

                    new Student { Id = 11, Name = "Ino", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 6 },
                    new Student { Id = 12, Name = "Suske", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 6 },

                    new Student { Id = 13, Name = "Gaara", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 7 },
                    new Student { Id = 14, Name = "Temari", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 7 },

                    new Student { Id = 15, Name = "Kankuro", Address = "Dhaka", Gender = Gender.Male, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 8 },
                    new Student { Id = 16, Name = "Konohamaru", Address = "Gazipur", Gender = Gender.Female, DateOfBirth = new DateOnly(2000, 1, 20), ClassLevelNumber = 8 }
                );
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Gender).HasConversion<string>();
                entity.Property(e => e.Designation).HasConversion<string>();

                entity.HasData(

                    new Teacher { Id = 1,  Name = "Jiraiya", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.Professor,           DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 2,  Name = "Tsunade", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.Professor,           DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 3,  Name = "Hiruzen", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.Professor,           DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 4,  Name = "Minato", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.Professor,           DateOfBirth = new DateOnly(2000, 1, 20)},
                    
                    new Teacher { Id = 5,  Name = "Kahashi Sensei", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.AssociateProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 6,  Name = "Yamato", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.AssociateProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 7,  Name = "Might Guy", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.AssociateProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 8,  Name = "Asuma", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.AssociateProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    
                    new Teacher { Id = 9,  Name = "Orochimaru", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.AssistantProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 10, Name = "Nagato", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.AssistantProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 11, Name = "Yahiko", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.AssistantProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 12, Name = "Kisame", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.AssistantProfessor,  DateOfBirth = new DateOnly(2000, 1, 20)},
                    
                    new Teacher { Id = 13, Name = "Iruka Sensei", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.Lecturer,            DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 14, Name = "Itachi Uchiha", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.Lecturer,            DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 15, Name = "Deridara", Address = "Dhaka",   Gender = Gender.Male,   Designation = Designation.Lecturer,            DateOfBirth = new DateOnly(2000, 1, 20)},
                    new Teacher { Id = 16, Name = "Tobi", Address = "Gazipur", Gender = Gender.Female, Designation = Designation.Lecturer,            DateOfBirth = new DateOnly(2000, 1, 20)}
                );
            });  
        }
    }
}
