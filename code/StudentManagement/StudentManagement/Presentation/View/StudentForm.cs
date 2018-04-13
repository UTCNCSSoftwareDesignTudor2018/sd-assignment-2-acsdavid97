using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using StudentManagement.Presentation.Presenter;

namespace StudentManagement.Presentation.View
{
    public partial class StudentForm : Form
    {
        private Student _student;
        private readonly StudentFormController _studentFormController;

        public StudentForm(Student student, StudentBll studentBll)
        {
            _student = student;
            InitializeComponent();
            _studentFormController = new StudentFormController(this, studentBll);
        }


        public void LoadStudent(Student student)
        {
            _student = student;
            studentBindingSource.DataSource = student;
        }

        public void LoadAvailableCourses(IList<Course> courses)
        {
            availableCourseBindingSource.DataSource = courses;
        }

        public void LoadEnrolledCourses(IList<Course> courses)
        {
            enrolledCourseList.DataSource = courses;
        }

        public void LoadStudentGrades(IList<Grade> grades)
        {
            gradeBindingSource.DataSource = grades;
        }

        public Student GetStudent()
        {
            return _student;
        }

        public Course GetSelectedAvailableCourse()
        {
            return availableCourseList.SelectedItem as Course;
        }

        public Course GetSelectedEnrolledCourse()
        {
            return enrolledCourseList.SelectedItem as Course;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            _studentFormController.UpdateStudent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            _studentFormController.UnEnrollCourse();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            _studentFormController.EnrollCourse();
        }
    }
}
