using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        [ForeignKey("Classroom")]
        public int ClassroomId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public Classroom Classroom { get; set; }
    }
}
