using CoreHomework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHomework2.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> All();
        Student Read(int id);
        void Update(Student student);
        void Create(Student student);
        void Delete(int id);
    }
}
