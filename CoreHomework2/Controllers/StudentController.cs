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
        [HttpGet]
        public IActionResult All()
        {
            var students = new Student[0];
            return View(students);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            return View();
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