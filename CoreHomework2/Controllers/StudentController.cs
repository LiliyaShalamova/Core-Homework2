using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHomework2.Models;

namespace CoreHomework2.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db;
        public StudentController(StudentContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult All()
        {
            var students = db.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("All"); ;
        }

        [HttpGet]
        public IActionResult Read(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}