using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Core.Models.StudentModels
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Foreign key for ClassLevelw
        public int ClassLevelNumber { get; set; }

        // Navigation property for the related ClassLevel
        [ForeignKey("ClassLevelNumber")]
        public ClassLevel ClassLevel { get; set; }
    }
}
