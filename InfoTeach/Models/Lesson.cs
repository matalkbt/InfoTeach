using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        [Key]
        public int LessonId{ get; set; }

        [Required(ErrorMessage = "Please enter a name for the lesson.")]
        [StringLength(200)]
        public string LessonName { get; set; }

        [Required(ErrorMessage = "Please select a subject for the lesson.")]
        [Range(1,int.MaxValue)]
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }

        public ICollection<Curriculum> Curriculums { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public Subject Subject { get; set; }


    }
}
