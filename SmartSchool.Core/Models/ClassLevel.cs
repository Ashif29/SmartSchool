using SmartSchool.Core.Models.RoomModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Core.Models
{
    public class ClassLevel
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [ForeignKey("RoomNumber")]

        public Room Room { get; set; }

    }
}
