namespace TeacherProgram.Presentation.View
{
    partial class StudentEditView
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
            this.studentView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.addressText = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.pncText = new System.Windows.Forms.TextBox();
            this.personalNumbericalCodeLabel = new System.Windows.Forms.Label();
            this.cardText = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.groupText = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.studentCourseView = new System.Windows.Forms.DataGridView();
            this.studentGradeView = new System.Windows.Forms.DataGridView();
            this.generateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGradedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeBinding = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBinding = new System.Windows.Forms.BindingSource(this.components);
            this.studentBinding = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumericalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentListBinding = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gradeStudentButton = new System.Windows.Forms.Button();
            this.markBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentView
            // 
            this.studentView.AllowUserToAddRows = false;
            this.studentView.AllowUserToDeleteRows = false;
            this.studentView.AllowUserToOrderColumns = true;
            this.studentView.AutoGenerateColumns = false;
            this.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn,
            this.personalNumericalCodeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.studentView.DataSource = this.studentListBinding;
            this.studentView.Location = new System.Drawing.Point(12, 28);
            this.studentView.MultiSelect = false;
            this.studentView.Name = "studentView";
            this.studentView.ReadOnly = true;
            this.studentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentView.Size = new System.Drawing.Size(553, 186);
            this.studentView.TabIndex = 1;
            this.studentView.SelectionChanged += new System.EventHandler(this.studentView_SelectionChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(928, 371);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 23);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update Student";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addressText
            // 
            this.addressText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBinding, "Address", true));
            this.addressText.Location = new System.Drawing.Point(801, 304);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(192, 20);
            this.addressText.TabIndex = 20;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(661, 311);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 19;
            this.addressLabel.Text = "Address:";
            // 
            // pncText
            // 
            this.pncText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBinding, "PersonalNumericalCode", true));
            this.pncText.Location = new System.Drawing.Point(801, 225);
            this.pncText.Name = "pncText";
            this.pncText.Size = new System.Drawing.Size(192, 20);
            this.pncText.TabIndex = 18;
            // 
            // personalNumbericalCodeLabel
            // 
            this.personalNumbericalCodeLabel.AutoSize = true;
            this.personalNumbericalCodeLabel.Location = new System.Drawing.Point(661, 232);
            this.personalNumbericalCodeLabel.Name = "personalNumbericalCodeLabel";
            this.personalNumbericalCodeLabel.Size = new System.Drawing.Size(126, 13);
            this.personalNumbericalCodeLabel.TabIndex = 17;
            this.personalNumbericalCodeLabel.Text = "Personal numerical code:";
            // 
            // cardText
            // 
            this.cardText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBinding, "CardNumber", true));
            this.cardText.Location = new System.Drawing.Point(801, 169);
            this.cardText.Name = "cardText";
            this.cardText.Size = new System.Drawing.Size(192, 20);
            this.cardText.TabIndex = 16;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(661, 176);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.cardNumberLabel.TabIndex = 15;
            this.cardNumberLabel.Text = "Card number:";
            // 
            // groupText
            // 
            this.groupText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBinding, "Group", true));
            this.groupText.Location = new System.Drawing.Point(801, 99);
            this.groupText.Name = "groupText";
            this.groupText.Size = new System.Drawing.Size(192, 20);
            this.groupText.TabIndex = 14;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(661, 106);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(39, 13);
            this.groupLabel.TabIndex = 13;
            this.groupLabel.Text = "Group:";
            // 
            // nameText
            // 
            this.nameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBinding, "Name", true));
            this.nameText.Location = new System.Drawing.Point(801, 42);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(192, 20);
            this.nameText.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(661, 49);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name:";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(656, 371);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 22;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(801, 371);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(94, 23);
            this.deleteStudent.TabIndex = 23;
            this.deleteStudent.Text = "Delete Student";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // studentCourseView
            // 
            this.studentCourseView.AutoGenerateColumns = false;
            this.studentCourseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentCourseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.teacherDataGridViewTextBoxColumn});
            this.studentCourseView.DataSource = this.courseBinding;
            this.studentCourseView.Location = new System.Drawing.Point(12, 249);
            this.studentCourseView.MultiSelect = false;
            this.studentCourseView.Name = "studentCourseView";
            this.studentCourseView.ReadOnly = true;
            this.studentCourseView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentCourseView.Size = new System.Drawing.Size(247, 150);
            this.studentCourseView.TabIndex = 24;
            // 
            // studentGradeView
            // 
            this.studentGradeView.AutoGenerateColumns = false;
            this.studentGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGradeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseDataGridViewTextBoxColumn,
            this.dateGradedDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn});
            this.studentGradeView.DataSource = this.gradeBinding;
            this.studentGradeView.Location = new System.Drawing.Point(288, 249);
            this.studentGradeView.MultiSelect = false;
            this.studentGradeView.Name = "studentGradeView";
            this.studentGradeView.ReadOnly = true;
            this.studentGradeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGradeView.Size = new System.Drawing.Size(346, 150);
            this.studentGradeView.TabIndex = 25;
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(428, 415);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(94, 23);
            this.generateReport.TabIndex = 26;
            this.generateReport.Text = "Generate Report";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Student\'s courses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Student\'s marks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Students:";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateGradedDataGridViewTextBoxColumn
            // 
            this.dateGradedDataGridViewTextBoxColumn.DataPropertyName = "DateGraded";
            this.dateGradedDataGridViewTextBoxColumn.HeaderText = "DateGraded";
            this.dateGradedDataGridViewTextBoxColumn.Name = "dateGradedDataGridViewTextBoxColumn";
            this.dateGradedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeBinding
            // 
            this.gradeBinding.DataSource = typeof(StudentManagement.Business.Entity.Grade);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseBinding
            // 
            this.courseBinding.DataSource = typeof(StudentManagement.Business.Entity.Course);
            // 
            // studentBinding
            // 
            this.studentBinding.DataSource = typeof(StudentManagement.Business.Entity.Student);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalNumericalCodeDataGridViewTextBoxColumn
            // 
            this.personalNumericalCodeDataGridViewTextBoxColumn.DataPropertyName = "PersonalNumericalCode";
            this.personalNumericalCodeDataGridViewTextBoxColumn.HeaderText = "PersonalNumericalCode";
            this.personalNumericalCodeDataGridViewTextBoxColumn.Name = "personalNumericalCodeDataGridViewTextBoxColumn";
            this.personalNumericalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentListBinding
            // 
            this.studentListBinding.DataSource = typeof(StudentManagement.Business.Entity.Student);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1014, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradeStudentButton
            // 
            this.gradeStudentButton.Location = new System.Drawing.Point(165, 415);
            this.gradeStudentButton.Name = "gradeStudentButton";
            this.gradeStudentButton.Size = new System.Drawing.Size(94, 23);
            this.gradeStudentButton.TabIndex = 31;
            this.gradeStudentButton.Text = "Grade Student";
            this.gradeStudentButton.UseVisualStyleBackColor = true;
            this.gradeStudentButton.Click += new System.EventHandler(this.gradeStudentButton_Click);
            // 
            // markBox
            // 
            this.markBox.Location = new System.Drawing.Point(15, 417);
            this.markBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.markBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(120, 20);
            this.markBox.TabIndex = 32;
            this.markBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StudentEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.markBox);
            this.Controls.Add(this.gradeStudentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.studentGradeView);
            this.Controls.Add(this.studentCourseView);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.pncText);
            this.Controls.Add(this.personalNumbericalCodeLabel);
            this.Controls.Add(this.cardText);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.groupText);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.studentView);
            this.Name = "StudentEditView";
            this.Text = "StudentEditView";
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentView;
        private System.Windows.Forms.BindingSource studentBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNumericalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox pncText;
        private System.Windows.Forms.Label personalNumbericalCodeLabel;
        private System.Windows.Forms.TextBox cardText;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox groupText;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource studentListBinding;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.BindingSource courseBinding;
        private System.Windows.Forms.DataGridView studentCourseView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView studentGradeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource gradeBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGradedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gradeStudentButton;
        private System.Windows.Forms.NumericUpDown markBox;
    }
}