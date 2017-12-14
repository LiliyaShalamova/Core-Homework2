using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreHomework2.Models;

namespace CoreHomework2.Services
{
    public class StudentService : IStudentService
    {
        private StudentContext db;
        public StudentService(StudentContext context)
        {
            db = context;
        }

        public IEnumerable<Student> All()
        {
            return db.Students;
        }

        public void Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = Read(id);
            db.Remove(student);
            db.SaveChanges();
        }

        public Student Read(int id)
        {
            return db.Students.FirstOrDefault(s => s.Id == id);
        }

        public void Update(Student student)
        {
            db.Students.Update(student);
            db.SaveChanges();
        }
    }
}
