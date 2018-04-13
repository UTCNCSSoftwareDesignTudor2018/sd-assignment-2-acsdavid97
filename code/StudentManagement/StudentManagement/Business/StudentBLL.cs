using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Business
{
    public class StudentBll
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public StudentBll(IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }

        public IList<Course> GetCourses()
        {
            return _courseRepository.GetAll();
        }

        public void UnEnrollStudent(Student student, Course course)
        {
            student.UnEnrollCourse(course);
            _studentRepository.Update(student);
        }

        public void EnrollStudent(Student student, Course course)
        {
            student.EnrollCourse(course);
            _studentRepository.Update(student);
        }

        public Student GetStudent(Student student)
        {
            Student updatedStudent = _studentRepository.Get(student);
            return updatedStudent;
        }
    }
}
