namespace TeacherProgram.Presentation.View
{
    partial class CourseEditView
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
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseListBinding = new System.Windows.Forms.BindingSource(this.components);
            this.teacherListBinding = new System.Windows.Forms.BindingSource(this.components);
            this.teacherListbox = new System.Windows.Forms.ListBox();
            this.courseName = new System.Windows.Forms.TextBox();
            this.courseBinding = new System.Windows.Forms.BindingSource(this.components);
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseListBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AllowUserToAddRows = false;
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.courseDataGridView.DataSource = this.courseListBinding;
            this.courseDataGridView.Location = new System.Drawing.Point(21, 31);
            this.courseDataGridView.MultiSelect = false;
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.Size = new System.Drawing.Size(382, 249);
            this.courseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Teacher";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teacher";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // courseListBinding
            // 
            this.courseListBinding.DataSource = typeof(StudentManagement.Business.Entity.Course);
            // 
            // teacherListBinding
            // 
            this.teacherListBinding.DataSource = typeof(StudentManagement.Business.Entity.Teacher);
            // 
            // teacherListbox
            // 
            this.teacherListbox.DataSource = this.teacherListBinding;
            this.teacherListbox.FormattingEnabled = true;
            this.teacherListbox.Location = new System.Drawing.Point(21, 308);
            this.teacherListbox.Name = "teacherListbox";
            this.teacherListbox.Size = new System.Drawing.Size(382, 186);
            this.teacherListbox.TabIndex = 2;
            // 
            // courseName
            // 
            this.courseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBinding, "Name", true));
            this.courseName.Location = new System.Drawing.Point(617, 308);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(149, 20);
            this.courseName.TabIndex = 3;
            // 
            // courseBinding
            // 
            this.courseBinding.DataSource = typeof(StudentManagement.Business.Entity.Course);
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(548, 308);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(38, 13);
            this.courseNameLabel.TabIndex = 4;
            this.courseNameLabel.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(766, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teachers list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Courses List:";
            // 
            // CourseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.teacherListbox);
            this.Controls.Add(this.courseDataGridView);
            this.Name = "CourseEditView";
            this.Text = "CourseEditView";
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseListBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseListBinding;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource teacherListBinding;
        private System.Windows.Forms.ListBox teacherListbox;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource courseBinding;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}