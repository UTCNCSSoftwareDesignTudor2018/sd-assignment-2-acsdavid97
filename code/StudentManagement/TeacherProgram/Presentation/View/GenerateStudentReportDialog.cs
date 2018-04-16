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
    public partial class GenerateStudentReportDialog : Form
    {
        public GenerateStudentReportDialog()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (pdfButton.Checked)
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }

            if (mongoDbButton.Checked)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        public bool PdfSelected => pdfButton.Checked;
        public bool MongoDbSelected => mongoDbButton.Checked;

        public DateTime GetStartDate()
        {
            return startDatePicker.SelectionStart;
        }

        public DateTime GetEndDate()
        {
            return endDatePicker.SelectionStart;
        }

        public string GetPath()
        {
            return saveFileDialog1.FileName;
        }
    }
}
