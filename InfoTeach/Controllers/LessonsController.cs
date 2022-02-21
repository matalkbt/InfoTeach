using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using InfoTeach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Controllers
{
    public class LessonsController : Controller
    {
        private readonly ILogger<LessonsController> _logger;
        private LessonsContext _ctx { get; set; }

        public LessonsController(ILogger<LessonsController> logger, LessonsContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        public IActionResult MyLessons()
        {
            _logger.LogDebug("Navigating to 'MyLessons'");
            return View();
        }

        [HttpGet]
        public ActionResult MySubjects()
        {
            _logger.LogDebug("Subjects requested, querying database...");
            var subjects = _ctx.Subjects.ToList();
            return PartialView("_Subjects",subjects);
        }

        [HttpGet]
        public ActionResult Lessons(int subjectId)
        {
            _logger.LogDebug($"Lessons requested with subject id = {subjectId}, querying database...");
            var lessons = _ctx.Lessons
                .Where(l => l.SubjectId == subjectId)
                .ToList();

            return PartialView("_Lessons",lessons);
        }

        [HttpGet]
        public ActionResult MyAssignments(int lessonId)
        {
            _logger.LogDebug($"Assignments requested with lesson id = {lessonId}, querying database...");
            var assignments = _ctx.Assignments
                .Where(a=> a.LessonId==lessonId)
                .ToList();
            return PartialView("_Assignments",assignments);
        }

        [HttpGet]
        public ActionResult LoadAssignment(int assignmentId)
        {
            _logger.LogDebug($"Assignment requested with assignment id = {assignmentId}, querying database...");
            var questions = _ctx.Questions
                .Where(a => a.AssignmentId == assignmentId)
                .ToList();
            return PartialView("_AssignmentLayout", questions);
        }

    }
}
