﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Core.Models.Teacher.DTOs
{
    public class TeacherCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public Designation Designation { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public DateOnly DateOfBirth { get; set; }
    }
}
