using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using StudentManagement.Business.Entity;
using StudentManagement.Business.Validator;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;
using StudentManagement.Reporting;

namespace StudentManagement.Business
{
    /// <summary>
    /// Business logic operations for Students: Validation, Enrollment, CRUD.
    /// </summary>
    public class StudentBll
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGenericValidator<User> _userValidator;

        public StudentBll(IStudentRepository studentRepository, IGenericValidator<User> userValidator)
        {
            _studentRepository = studentRepository;
            _userValidator = userValidator;
        }

        public void AddStudent(Student student)
        {
            _userValidator.Validate(student);
            _studentRepository.Insert(student);
        }

        public void UpdateStudent(Student student)
        {
            _userValidator.Validate(student);
            _studentRepository.Update(student);
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

        public IList<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudent(Student student)
        {
            Student updatedStudent = _studentRepository.Get(student);
            return updatedStudent;
        }

        public void DeleteStudent(Student student)
        {
            _studentRepository.Delete(student);
        }



        public void GradeStudent(Student student, Course course, int mark)
        {
            var grade = new Grade
            {
                Course = course,
                Mark = mark,
                Student = student,
                DateGraded = DateTime.Now
            };
            student.AddGrade(grade);
            _studentRepository.Update(student);
        }
    }
}
