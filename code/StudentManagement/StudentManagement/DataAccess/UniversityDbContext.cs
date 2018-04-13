using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business;
using StudentManagement.Business.Entity;

namespace StudentManagement.DataAccess
{
    public class UniversityDbContext : DbContext, IUniversityDbContext
    {
        public UniversityDbContext() : base("name=UniversityDbContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // configure domain classes using domain builder

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
