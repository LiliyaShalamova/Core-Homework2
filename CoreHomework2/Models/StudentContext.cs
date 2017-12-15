using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHomework2.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options)
            :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>()
                .Property(s => s.University)
                .IsRequired();
        }
    }
}
