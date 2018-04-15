using System.Collections.Generic;
using System.Linq;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using TeacherProgram.Presentation.View;

namespace TeacherProgram.Presentation.Presenter
{
    internal class TeacherFormPresenter
    {
        private readonly TeacherEditView _teacherEditView;
        private readonly StudentBll _studentBll;
        private readonly TeacherBll _teacherBll;

        public TeacherFormPresenter(TeacherEditView teacherEditView, StudentBll studentBll, TeacherBll teacherBll)
        {
            _teacherEditView = teacherEditView;
            _studentBll = studentBll;
            _teacherBll = teacherBll;

            UpdateForm();
        }

        private void UpdateForm()
        {
            _teacherEditView.LoadTeachers(_teacherBll.GetTeachers());
        }

        public void TeacherSelected(Teacher teacher)
        {
            _teacherEditView.LoadCourses(teacher.Courses.ToList());
        }

        public void AddTeacher(Teacher teacher)
        {
            teacher.Courses = new List<Course>();
            _teacherBll.AddTeacher(teacher);

            UpdateForm();
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _teacherBll.DeleteTeacher(teacher);

            UpdateForm();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherBll.UpdateTeacher(teacher);

            UpdateForm();
        }
    }
}