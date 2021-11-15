using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Please select which assignment this belongs to.")]
        [Range(1,int.MaxValue)]
        [ForeignKey("Assignment")]
        public int AssignmentId { get; set; }

        [Required(ErrorMessage = "Please select the question type.")]
        [Range(1, int.MaxValue)]
        [ForeignKey("QuestionType")]
        public int QuestionTypeId { get; set; }

        [Required(ErrorMessage = "Please enter the question.")]
        [StringLength(1000)]
        public string QuestionText { get; set; }

        public ICollection<Answer> Answers { get; set; }
        public QuestionType QuestionType { get; set; }
        public Assignment Assignment { get; set; }
    }
}
