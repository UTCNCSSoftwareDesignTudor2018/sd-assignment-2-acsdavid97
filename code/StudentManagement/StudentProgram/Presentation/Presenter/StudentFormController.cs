using System.Linq;
using StudentManagement.Business;
using StudentProgram.Presentation.View;

namespace StudentProgram.Presentation.Presenter
{
    class StudentFormController
    {
        private readonly StudentForm _studentForm;
        private readonly StudentBll _studentBll;
        private readonly CourseBll _courseBll;

        public StudentFormController(StudentForm studentForm, StudentBll studentBll, CourseBll courseBll)
        {
            _studentForm = studentForm;
            _studentBll = studentBll;
            _courseBll = courseBll;
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
            var availableCourses = _courseBll.GetCourses();
            foreach(var course in updatedStudent.Courses)
            {
                availableCourses.Remove(course);
            }
            _studentForm.LoadAvailableCourses(availableCourses);

            _studentForm.LoadStudentGrades(updatedStudent.Grades.ToList());
        }
    }
}
