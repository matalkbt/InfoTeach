using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    public class assignment
    {
        //Rename this class
        public int assignment_id { get; set; }
        public int lesson_id { get; set; }
        public int question_type_id { get; set; }
        public string assignment_text { get; set; }
    }
}
