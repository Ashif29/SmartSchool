using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSchool.Core.Models.TeacherModels;

namespace SmartSchool.Core.Models.CourseModels
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public CourseType CourseType { get; set; }

        public bool IsTaken { get; set; } = false;

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Foreign key for ClassLevel
        public int ClassLevelNumber { get; set; }

        // Navigation property for the related ClassLevel
        [ForeignKey("ClassLevelNumber")]
        public ClassLevel ClassLevel { get; set; }


        // Foreign key for Teacher
        public int? TeacherId { get; set; }

        // Navigation property for the related ClassLevel
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
    }
}
