using Microsoft.AspNetCore.Mvc;
using Schoolscores.Data;
using Schoolscores.Models;

namespace Schoolscores.Controllers
{
    public class TeacherController : Controller
    {
        //make it work
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            Teacher teacher = new Teacher();
            return View(teacher);
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(Teacher teacher)
        {
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


    }
}
