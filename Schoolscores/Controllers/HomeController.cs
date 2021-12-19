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


            var vm = new HomeVM
            {
                //Students = new List<Student>(),
                //Teachers = new List<Teacher>(),
                Studentscores = new List<Examscores>(),
                Teachers = _context.Teachers.ToList(),
                Students = _context.Students.ToList(),
                //Studentscores = Examscores,
                //Labels = Labels,
                //Values = Values
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