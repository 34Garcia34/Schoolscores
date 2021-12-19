using Microsoft.AspNetCore.Mvc;
using Schoolscores.Models.ViewModels;
using Schoolscores.Models;
using Schoolscores.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
                Text = $"{x.FirstName} {x.LastName} {x.ExamScore}",
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

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            CreateIExamVM vm = new CreateIExamVM
            {
                Student = _context.Students.FirstOrDefault(x => x.StudentId == id),
                StudentList = _context.Students.Select(x => new SelectListItem
                {
                    Text = $"{x.FirstName} {x.LastName} {x.ExamScore}",
                    Value = x.StudentId.ToString()
                })
            };
            return View(vm);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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
