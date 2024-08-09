using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Models.Course;
using SmartSchool.Core.Models.Room;
using SmartSchool.Core.Models.Student;
using SmartSchool.Core.Models.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed Room data
            modelBuilder.Entity<Room>().HasData(
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


            // Seed SchoolClass data
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

        }
    }
}
