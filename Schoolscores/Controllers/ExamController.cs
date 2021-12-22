using Microsoft.AspNetCore.Mvc;
using Schoolscores.Models;
using Schoolscores.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Schoolscores.Controllers
{
    public class ExamController : Controller
    {

        private readonly AppDbContext _context;

        public ExamController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ExamVM vm = new ExamVM
            {
                StudentList = _context.Students.Select(x => new SelectListItem
                {
                    Text = $"{x.FirstName} {x.LastName}",
                    Value = x.StudentId.ToString()
                }),
                TeachersList = _context.Teachers.Select(x => new SelectListItem
                {
                    Text = $"{x.FirstName} {x.LastName}",
                    Value = x.TeacherId.ToString()
                }),
                Exam = new Exam()
            };
            return View(vm);
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
            Exam exam = _context.Exams.FirstOrDefault(x => x.ExamId == id);
            return View(exam);
        }

        [HttpPost]
        public IActionResult Edit(Exam exam)
        {
            _context.Exams.Update(exam);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // GET: StudentController/Delete/5
        public IActionResult Delete(int id)
        {
            var exam = _context.Exams.FirstOrDefault(x => x.ExamId == id);
            _context.Exams.Remove(exam);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
