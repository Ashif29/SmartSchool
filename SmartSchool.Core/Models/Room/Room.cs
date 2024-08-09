using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Core.Models.Room
{
    public class Room
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomNumber { get; set; }
        public string? Description { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int Capacity { get; set; } = 50;
    }
}
