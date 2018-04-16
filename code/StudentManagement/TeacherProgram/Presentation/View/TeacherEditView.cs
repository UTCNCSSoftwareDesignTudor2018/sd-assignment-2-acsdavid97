using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess.Repository;
using TeacherProgram.Presentation.Presenter;

namespace TeacherProgram.Presentation.View
{
    public partial class TeacherEditView : Form
    {
        private Teacher _teacher;
        private readonly TeacherFormPresenter _teacherFormPresenter;

        public TeacherEditView(StudentBll studentBll, TeacherBll teacherBll)
        {
            InitializeComponent();
            _teacherFormPresenter = new TeacherFormPresenter(this, studentBll, teacherBll);
        }

        public void LoadTeachers(IList<Teacher> teachers)
        {
            teacherView.DataSource = teachers;
        }

        public void LoadCourses(IList<Course> courses)
        {
            courseView.DataSource = courses;
        }

        public Teacher SelectedTeacher => teacherView.CurrentRow?.DataBoundItem as Teacher;

        private void teacherView_SelectionChanged(object sender, System.EventArgs e)
        {
            _teacher = SelectedTeacher;
            teacherBinding.DataSource = _teacher;
            _teacherFormPresenter.TeacherSelected(_teacher);
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            _teacherFormPresenter.AddTeacher(_teacher);
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            _teacherFormPresenter.DeleteTeacher(_teacher);
        }

        private void updateButton_Click(object sender, System.EventArgs e)
        {
            _teacherFormPresenter.UpdateTeacher(_teacher);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            _teacherFormPresenter.UpdateForm();
        }
    }
}
