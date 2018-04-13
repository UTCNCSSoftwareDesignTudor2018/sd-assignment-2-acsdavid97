using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using StudentManagement.Presentation.View;

namespace StudentManagement.Presentation.Presenter
{
    class StudentFormController
    {
        private readonly StudentForm _studentForm;
        private readonly StudentBll _studentBll;

        public StudentFormController(StudentForm studentForm, StudentBll studentBll)
        {
            _studentForm = studentForm;
            _studentBll = studentBll;
            UpdateForm();
        }

        public void UpdateStudent()
        {
            var student = _studentForm.GetStudent();
            _studentBll.UpdateStudent(student);
            UpdateForm();
        }

        public void UnEnrollCourse()
        {
            var student = _studentForm.GetStudent();
            var course = _studentForm.GetSelectedEnrolledCourse();
            if (course == null)
            {
                return;
            }
            _studentBll.UnEnrollStudent(student, course);
            UpdateForm();
        }

        public void EnrollCourse()
        {
            var student = _studentForm.GetStudent();
            var course = _studentForm.GetSelectedAvailableCourse();
            if (course == null)
            {
                return;
            }
            _studentBll.EnrollStudent(student, course);
            UpdateForm();
        }

        private void UpdateForm()
        {
            var oldStudent = _studentForm.GetStudent();

            var updatedStudent = _studentBll.GetStudent(oldStudent);
            _studentForm.LoadStudent(updatedStudent);

            _studentForm.LoadEnrolledCourses(updatedStudent.Courses.ToList());
            var availableCourses = _studentBll.GetCourses();
            foreach(var course in updatedStudent.Courses)
            {
                availableCourses.Remove(course);
            }
            _studentForm.LoadAvailableCourses(availableCourses);

            _studentForm.LoadStudentGrades(updatedStudent.Grades.ToList());
        }
    }
}
