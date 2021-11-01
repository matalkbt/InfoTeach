using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    public class Classroom
    {
        public int classroom_id { get; set; }
        public string class_name { get; set; }
        public List<User> instructors { get; set; }
        public List<User> students { get; set; }
        public List<Lesson> lessons { get; set; }
    }
}
