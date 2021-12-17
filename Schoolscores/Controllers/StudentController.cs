﻿using Microsoft.AspNetCore.Mvc;
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
            CreateIExamVM vm = new CreateIExamVM

            {
                Student = new Student(),
                StudentList = _context.Students.Select(x => new SelectListItem
                {
                    Text = $"{x.FirstName} {x.LastName}",
                    Value = x.StudentId.ToString()
                })
            };
            return View(vm);
        }

        // POST: StudentController/Create
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

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            CreateIExamVM vm = new CreateIExamVM
            {
                Student = _context.Students.FirstOrDefault(x => x.Id.ToString() == id),
                StudentList = _context.Students.Select(x => new SelectListItem
                {
                    Text = $"{x.FirstName} {x.LastName}",
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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