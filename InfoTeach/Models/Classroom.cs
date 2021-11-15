using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Classroom")]
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        [Required(ErrorMessage = "Please enter a name for the class.")]
        [StringLength(200)]
        public string ClassroomName { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Curriculum> Curriculums { get; set; }
    }
}
