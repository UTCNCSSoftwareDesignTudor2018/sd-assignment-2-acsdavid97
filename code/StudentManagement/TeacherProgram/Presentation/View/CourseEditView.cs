using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using TeacherProgram.Presentation.Presenter;

namespace TeacherProgram.Presentation.View
{
    public partial class CourseEditView : Form
    {
        private readonly CourseViewEditPresenter _courseViewPresenter;
        public CourseEditView(CourseBll courseBll, TeacherBll teacherBll)
        {
            InitializeComponent();
            _courseViewPresenter = new CourseViewEditPresenter(this, courseBll, teacherBll);
        }

        public void LoadCourses(IList<Course> courses)
        {
            courseListBinding.DataSource = courses;
        }

        public void LoadTeachers(IList<Teacher> teachers)
        {
            teacherListBinding.DataSource = teachers;
        }

        public Teacher SelectedTeacher => teacherListbox.SelectedItem as Teacher;

        private void button1_Click(object sender, EventArgs e)
        {
            _courseViewPresenter.AddCourse(courseName.Text, SelectedTeacher);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            _courseViewPresenter.UpdateForm();
        }
    }
}
