using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;

namespace StudentManagement.DataAccess.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IUniversityDbContext _universityDbContext;

        public CourseRepository(IUniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public Course Get(Course toGet)
        {
            return Get(toGet.CourseId);
        }

        public Course Get(int id)
        {
            return _universityDbContext.Courses.First(c => c.CourseId == id);
        }

        public IList<Course> GetAll()
        {
            return _universityDbContext.Courses.ToList();
        }

        public void Insert(Course toInsert)
        {
            _universityDbContext.Courses.Add(toInsert);
            _universityDbContext.SaveChanges();
        }

        public void Update(Course toUpdate)
        {
            _universityDbContext.Courses.AddOrUpdate(toUpdate);
            _universityDbContext.SaveChanges();
        }

        public void Delete(Course toDelete)
        {
            _universityDbContext.Courses.Remove(toDelete);
            _universityDbContext.SaveChanges();
        }
    }
}
