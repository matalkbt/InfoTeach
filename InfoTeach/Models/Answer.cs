using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int AnswerID { get; set; }

        [Required(ErrorMessage = "Please select which question this is answering.")]
        [Range(1, int.MaxValue)]
        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Please provide the answer.")]
        [StringLength(1000)]
        public string AnswerText {get; set; }
        public Question Question { get; set; }
    }
}
