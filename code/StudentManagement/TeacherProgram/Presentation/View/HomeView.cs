using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherProgram.Presentation.View
{
    public partial class HomeView : Form
    {
        private readonly StudentEditView _studentEditView;
        private readonly CourseEditView _courseEditView;
        private readonly TeacherEditView _teacherEditView;
        private readonly ReportView _reportView;
        public HomeView(StudentEditView studentEditView, TeacherEditView teacherEditView, CourseEditView courseEditView, ReportView reportView)
        {
            InitializeComponent();
            _studentEditView = studentEditView;
            _courseEditView = courseEditView;
            _reportView = reportView;
            _teacherEditView = teacherEditView;
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            _studentEditView.ControlBox = false;
            _studentEditView.Show();
            _studentEditView.UpdateUi();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            _teacherEditView.ControlBox = false;
            _teacherEditView.Show();
            _teacherEditView.UpdateUi();
        }

        private void coursesButton_Click(object sender, EventArgs e)
        {
            _courseEditView.ControlBox = false;
            _courseEditView.Show();
            _courseEditView.UpdateUi();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            _reportView.ControlBox = false;
            _reportView.Show();
            _reportView.UpdateUi();
        }
    }
}
