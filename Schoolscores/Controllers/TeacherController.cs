using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Schoolscores.Data;
using Schoolscores.Models;
using Schoolscores.Models.ViewModels;

namespace Schoolscores.Controllers
{
    public class TeacherController : Controller
    {
        //make it work
        private readonly AppDbContext _context;

        public IQueryable<SelectListItem> TeacherList { get; private set; }


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
            TeacherList = _context.Teachers.Select(x => new SelectListItem
            {
                Text = $"{x.FirstName} {x.LastName}",
                Value = x.TeacherId.ToString()
            });
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

        public IActionResult Delete(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(x => x.TeacherId == id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


    }
}
