namespace TeacherProgram.Presentation.View
{
    partial class ReportView
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
            this.components = new System.ComponentModel.Container();
            this.studentReportList = new System.Windows.Forms.ListBox();
            this.studentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentReportGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGradeView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentReportList
            // 
            this.studentReportList.DataSource = this.studentReportBindingSource;
            this.studentReportList.FormattingEnabled = true;
            this.studentReportList.Location = new System.Drawing.Point(33, 27);
            this.studentReportList.Name = "studentReportList";
            this.studentReportList.Size = new System.Drawing.Size(354, 381);
            this.studentReportList.TabIndex = 0;
            this.studentReportList.SelectedIndexChanged += new System.EventHandler(this.studentReportList_SelectedIndexChanged);
            // 
            // studentReportBindingSource
            // 
            this.studentReportBindingSource.DataSource = typeof(StudentManagement.Reporting.StudentReport);
            // 
            // studentReportGradeBindingSource
            // 
            this.studentReportGradeBindingSource.DataSource = typeof(StudentManagement.Reporting.StudentReportGrade);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mark";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mark";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // studentGradeView
            // 
            this.studentGradeView.AutoGenerateColumns = false;
            this.studentGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.studentGradeView.DataSource = this.studentReportGradeBindingSource;
            this.studentGradeView.Location = new System.Drawing.Point(420, 72);
            this.studentGradeView.Name = "studentGradeView";
            this.studentGradeView.Size = new System.Drawing.Size(351, 336);
            this.studentGradeView.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(706, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentGradeView);
            this.Controls.Add(this.studentReportList);
            this.Name = "ReportView";
            this.Text = "ReportView";
            ((System.ComponentModel.ISupportInitialize)(this.studentReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReportGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentReportList;
        private System.Windows.Forms.BindingSource studentReportBindingSource;
        private System.Windows.Forms.BindingSource studentReportGradeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView studentGradeView;
        private System.Windows.Forms.Button closeButton;
    }
}