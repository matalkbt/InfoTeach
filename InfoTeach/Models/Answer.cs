using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    public class Answer
    {
        public int answer_id { get; set; }
        public int assignment_id { get; set; }
        //I dont like the answers_text as a list. Maybe make an interface of answers and have various types to fit questions?
        public List<string> answers_text { get; set; }
    }
}
