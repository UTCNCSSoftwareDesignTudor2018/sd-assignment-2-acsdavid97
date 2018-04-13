using System;
using System.Data.Entity;
using StudentManagement.Business;
using StudentManagement.Business.Entity;

namespace StudentManagement.DataAccess
{
    public interface IUniversityDbContext : IDisposable
    {
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Course> Courses { get; set; }

        int SaveChanges();
    }
}