using System.Collections.Generic;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using TeacherProgram.Presentation.View;

namespace TeacherProgram.Presentation.Presenter
{
    internal class CourseViewEditPresenter
    {
        private readonly CourseEditView _courseEditView;
        private readonly CourseBll _courseBll;
        private readonly TeacherBll _teacherBll;

        public CourseViewEditPresenter(CourseEditView courseEditView, CourseBll courseBll, TeacherBll teacherBll)
        {
            _courseEditView = courseEditView;
            _courseBll = courseBll;
            _teacherBll = teacherBll;

            UpdateForm();
        }

        public void AddCourse(string courseNameText, Teacher selectedTeacher)
        {
            var course = new Course
            {
                Name = courseNameText,
                Students = new List<Student>(),
                Teacher = selectedTeacher,
            };
            _courseBll.AddCourse(course);

            UpdateForm();
        }

        internal void UpdateForm()
        {
            _courseEditView.LoadCourses(_courseBll.GetCourses());
            _courseEditView.LoadTeachers(_teacherBll.GetTeachers());
        }
    }
}