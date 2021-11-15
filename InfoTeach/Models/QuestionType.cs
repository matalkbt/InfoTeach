using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    [Table("QuestionTypes")]
    public class QuestionType
    {
        [Key]
        public int QuestionTypeId { get; set; }

        public string Description { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
