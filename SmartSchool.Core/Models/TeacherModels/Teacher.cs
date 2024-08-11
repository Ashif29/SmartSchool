﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSchool.Core.Models.CourseModels;

namespace SmartSchool.Core.Models.TeacherModels
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public Designation Designation { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation property for the related Course
        public List<Course>? CourseList { get; set; }
    }
}
