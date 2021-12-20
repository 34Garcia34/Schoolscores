using Microsoft.AspNetCore.Mvc;
using Schoolscores.Models;
using Schoolscores.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Schoolscores.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public object StudentList { get; private set; }

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            Student student = new Student();
            StudentList = _context.Students.Select(x => new SelectListItem
            {
                Text = $"{x.FirstName} {x.LastName}",
                Value = x.StudentId.ToString()
            });
            return View(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit(int id)
        {
            Student student = _context.Students.FirstOrDefault(x => x.StudentId == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // GET: StudentController/Delete/5
        public IActionResult Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentId == id);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
