using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Schoolscores.Data;
using Schoolscores.Models;

namespace Schoolscores.Controllers
{
    public class ExamController : Controller
    {

        private readonly AppDbContext _context;

        public object ExamList { get; private set; }

        public ExamController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ExamController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamController/Create
        public ActionResult Create()
        {
            IEnumerable<SelectListItem> list = _context.Students.Select(x => new SelectListItem
            {
                Text = x.FirstName + " " + x.LastName,
                Value = x.StudentId.ToString()
            });

            Examscores exam = new Examscores();
            ExamList = _context.ExamScores.Select(x => new SelectListItem
            {
                Text = $"{x.TearcherId} {x.StudentId} {x.Testscore}",
                Value = x.ExamId.ToString()
            });
            return View(exam);
        }

        [HttpPost]
        public IActionResult Create(Examscores exam)
        {
            _context.ExamScores.Add(exam);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // GET: ExamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamController/Edit/5
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

        // GET: ExamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
