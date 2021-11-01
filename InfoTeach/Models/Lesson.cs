using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Models
{
    public class LessonContext : DbContext
    {
        public DbSet<Lesson> lessons { get; set; }
    }
    public class Lesson
    {
        public int lesson_id { get; set; }
        public string lesson_name { get; set; }
        public int lesson_type { get; set; } = 0;
        public bool private_lesson { get; set; } = false;
        
    }
}
