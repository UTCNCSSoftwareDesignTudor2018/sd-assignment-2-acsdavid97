namespace TeacherProgram.Presentation.View
{
    partial class GenerateStudentReportDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endDatePicker = new System.Windows.Forms.MonthCalendar();
            this.startDatePicker = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pdfButton = new System.Windows.Forms.RadioButton();
            this.mongoDbButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(381, 42);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.TabIndex = 0;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(33, 42);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(464, 257);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(103, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(98, 257);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"PDF files|*.pdf\"";
            // 
            // pdfButton
            // 
            this.pdfButton.AutoSize = true;
            this.pdfButton.Checked = true;
            this.pdfButton.Location = new System.Drawing.Point(298, 228);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(62, 17);
            this.pdfButton.TabIndex = 6;
            this.pdfButton.TabStop = true;
            this.pdfButton.Text = "PDF file";
            this.pdfButton.UseVisualStyleBackColor = true;
            // 
            // mongoDbButton
            // 
            this.mongoDbButton.AutoSize = true;
            this.mongoDbButton.Location = new System.Drawing.Point(298, 252);
            this.mongoDbButton.Name = "mongoDbButton";
            this.mongoDbButton.Size = new System.Drawing.Size(75, 17);
            this.mongoDbButton.TabIndex = 7;
            this.mongoDbButton.TabStop = true;
            this.mongoDbButton.Text = "Mongo Db";
            this.mongoDbButton.UseVisualStyleBackColor = true;
            // 
            // GenerateStudentReportDialog
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(656, 295);
            this.Controls.Add(this.mongoDbButton);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GenerateStudentReportDialog";
            this.Text = "GenerateStudentReportDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar endDatePicker;
        private System.Windows.Forms.MonthCalendar startDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton pdfButton;
        private System.Windows.Forms.RadioButton mongoDbButton;
    }
}