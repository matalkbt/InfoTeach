using InfoTeach.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace InfoTeach
{
    public class LessonsContext : DbContext
    {
        public LessonsContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Classroom> Classrooms{ get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<QuestionType> question_Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PrimaryKey Defined
            modelBuilder.Entity<QuestionType>().HasKey(qt => qt.QuestionTypeId);
            //One2Many Question->Answers //Something feels off about this relationship
            modelBuilder.Entity<Answer>().HasOne(asw => asw.Question)
                .WithMany(asw => asw.Answers)
                .OnDelete(DeleteBehavior.Restrict);
            //One2Many Lesson->Assignments
            modelBuilder.Entity<Assignment>().HasOne(ass => ass.Lesson)
                .WithMany(ass => ass.Assignments)
                .OnDelete(DeleteBehavior.Restrict);
            //One2Many Assignment -> Questions
            modelBuilder.Entity<Question>().HasOne(q => q.Assignment)
                .WithMany(q => q.Questions)
                .OnDelete(DeleteBehavior.Restrict);
            //One2Many QuestionType -> Questions
            modelBuilder.Entity<Question>().HasOne(q => q.QuestionType)
                .WithMany(q => q.Questions)
                .OnDelete(DeleteBehavior.Restrict);
            //One2Many Subject -> Lesson relationships
            modelBuilder.Entity<Lesson>().HasOne(ls => ls.Subject)
                .WithMany(ls =>ls.Lessons)
                .OnDelete(DeleteBehavior.Restrict);
            //Many2Many Classrooms -> Lessons relationships
            modelBuilder.Entity<Curriculum>()
                .HasKey(cr => new { cr.ClassroomId, cr.LessonId});
            modelBuilder.Entity<Curriculum>().HasOne(cr => cr.Classroom)
                .WithMany(cr => cr.Curriculums)
                .HasForeignKey(cr => cr.ClassroomId);
            modelBuilder.Entity<Curriculum>().HasOne(cr => cr.Lesson)
                .WithMany(cr => cr.Curriculums)
                .HasForeignKey(cr => cr.LessonId);
            //Many2Many Users -> Classroom *Students* relationships
            modelBuilder.Entity<Student>()
                .HasKey(st => new { st.UserId, st.ClassroomId });
            modelBuilder.Entity<Student>().HasOne(st => st.Classroom)
                .WithMany(st => st.Students)
                .HasForeignKey(st => st.UserId);
            modelBuilder.Entity<Student>().HasOne(st => st.User)
                .WithMany(st => st.Students)
                .HasForeignKey(st => st.ClassroomId);
            //Many2Many Users -> Classroom *Teachers* relationships
            modelBuilder.Entity<Teacher>()
                .HasKey(tr => new { tr.UserId, tr.ClassroomId });
            modelBuilder.Entity<Teacher>().HasOne(tr => tr.Classroom)
                .WithMany(tr => tr.Teachers)
                .HasForeignKey(tr => tr.UserId);
            modelBuilder.Entity<Teacher>().HasOne(tr => tr.User)
                .WithMany(tr => tr.Teachers)
                .HasForeignKey(tr => tr.ClassroomId);
        }

    }
}