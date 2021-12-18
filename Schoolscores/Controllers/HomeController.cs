using Microsoft.AspNetCore.Mvc;
using Schoolscores.Models;
using Schoolscores.Models.ViewModels;
using System.Diagnostics;

namespace Schoolscores.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var vm = new HomeVM
            {
                Students = new List<Student>(),
                Teachers = new List<Teacher>(),
                ExamScores = new List<Examscores>()
            };
            return View(vm);
        }

        public IActionResult Privacy()
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