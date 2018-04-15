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
    public partial class StudentEditView : Form
    {
        private Student _student = null;
        private readonly StudentEditPresenter _studentEditPresenter;

        public StudentEditView(StudentBll studentBll)
        {
            InitializeComponent();
            _studentEditPresenter = new StudentEditPresenter(this, studentBll);
        }

        public Student GetStudent()
        {
            return _student;
        }

        public void LoadStudents(IList<Student> students)
        {
            studentView.DataSource = students;
        }

        public void LoadStudentCourses(IList<Course> courses)
        {
            studentCourseView.DataSource = courses;
        }

        public void LoadStudentGrades(IList<Grade> grades)
        {
            studentGradeView.DataSource = grades;
        }

        public Student SelectedStudent => studentView.CurrentRow?.DataBoundItem as Student;

        private void studentView_SelectionChanged(object sender, EventArgs e)
        {
            _student = SelectedStudent;
            studentBinding.DataSource = _student;
            _studentEditPresenter.StudentSelected(_student);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _studentEditPresenter.UpdateStudent(_student);
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            _studentEditPresenter.AddStudent(_student);
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            _studentEditPresenter.DeleteStudent(_student);
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            _studentEditPresenter.GenerateReport(_student);
        }
    }
}
