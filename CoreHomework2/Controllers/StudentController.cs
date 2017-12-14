using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHomework2.Models;
using CoreHomework2.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoreHomework2.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService service)
        {
            studentService = service;
        }

        [HttpGet]
        public IActionResult All()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromServices]IStudentService service, Student student)
        {
            if (!ModelState.IsValid)
                return View(student);
            service.Create(student);
            return RedirectToAction("All"); ;
        }

        [HttpGet]
        public IActionResult Read(int id)
        {
            var service = ActivatorUtilities
                .GetServiceOrCreateInstance<IStudentService>(HttpContext.RequestServices);
            var student = service.Read(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = studentService.Read(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);
            studentService.Update(student);
            return RedirectToAction("All");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            studentService.Delete(id);
            return RedirectToAction("All");
        }
    }
}