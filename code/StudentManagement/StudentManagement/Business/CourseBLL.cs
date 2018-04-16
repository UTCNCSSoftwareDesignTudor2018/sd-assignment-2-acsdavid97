using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Business
{
    public class CourseBll
    {
        private readonly ICourseRepository _courseRepository;

        public CourseBll(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IList<Course> GetCourses()
        {
            return _courseRepository.GetAll();
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Insert(course);
        }
    }
}
