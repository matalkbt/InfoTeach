using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoTeach.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public ICollection<Lesson> Lessons {get;set;}
    }
}