using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoTeach.Models
{
    [Table("Curriculum")]
    public class Curriculum
    {
        [ForeignKey("Classroom")]
        public int ClassroomId { get; set; }

        [ForeignKey("Lesson")]
        public int LessonId { get; set; }

        public Classroom Classroom { get; set; }
        public Lesson Lesson { get; set; }
    }
}