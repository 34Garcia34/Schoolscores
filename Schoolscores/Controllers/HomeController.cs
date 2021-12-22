using Microsoft.AspNetCore.Mvc;
using Schoolscores.Data;
using Schoolscores.Models;
using Schoolscores.Models.ViewModels;
using System.Diagnostics;

namespace Schoolscores.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            //var NameList = _context.Students.GroupBy(x => x.Teachers.TeacherId).Select(i => new Examscores
            //{
            //    ExamId = i.Key,
            //    Testscore = i.Sum(t => t.examscore)

            //}).ToList();

            //List<Examscores> examscores = NameList;
            //List<string> labels = examscores.Select(x => x.StudentId).ToList();
            //List<decimal> values = examscores.Select(x => x.Testscore).ToList();
            var vm = new HomeVM
            {
                Teachers = _context.Teachers.ToList(),
                Students = _context.Students.ToList(),
                Studentscores = _context.ExamScores.ToList(),
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = false)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}