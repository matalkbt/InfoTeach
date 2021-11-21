using InfoTeach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LessonsContext _ctx;

        public HomeController(ILogger<HomeController> logger, LessonsContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult SiteUpdates()
        {
            return View();
        }
        public IActionResult Contribute()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
