using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.DataAccess.Repository;
using StudentManagement.Reporting;

namespace TeacherProgram.Presentation.View
{
    public partial class ReportView : Form
    {
        private readonly IReportRepository _reportRepository; 

        public ReportView(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
            InitializeComponent();
        }

        public void UpdateUi()
        {
            studentReportList.DataSource = _reportRepository.GetAll();
        }

        private void studentReportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentReport = studentReportList.SelectedItem as StudentReport;
            if (studentReport == null)
            {
                return;
            }

            studentGradeView.DataSource = studentReport.Grades;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
