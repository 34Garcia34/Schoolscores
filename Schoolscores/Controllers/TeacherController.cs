using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerInvoiceApp.Data;
using CustomerInvoiceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Schoolscores.Controllers
{
    public class TeacherController : Controller
    {
        // GET: TeacherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeacherController/Create
        public ActionResult Create()
        {
            Teachers teacher = new Teachers();
            return View(teacher);
        }

        [HttpPost]
        public IActionResult Create(Teachers teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            Teachers teacher = _context.Teachers.FirstOrDefault(x => x.TeacherId == id);
            return View(teacher);
        }

        [HttpPost]
        public IActionResult Edit(Teachers teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // POST: TeacherController/Edit/5
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

        public IActionResult Delete(string id)
        {
            var teacher = _context.Teachers.FirstOrDefault(x => x.TeacherId == id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // POST: TeacherController/Delete/5
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
