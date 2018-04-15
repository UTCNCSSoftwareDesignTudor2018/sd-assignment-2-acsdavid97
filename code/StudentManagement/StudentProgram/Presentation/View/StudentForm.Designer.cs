namespace StudentProgram.Presentation.View
{
    partial class StudentForm
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrolledCourseList = new System.Windows.Forms.ListBox();
            this.studentCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrolledCoursesLabel = new System.Windows.Forms.Label();
            this.availableCoursesLabel = new System.Windows.Forms.Label();
            this.leaveButton = new System.Windows.Forms.Button();
            this.availableCourseList = new System.Windows.Forms.ListBox();
            this.availableCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollButton = new System.Windows.Forms.Button();
            this.gradeListBox = new System.Windows.Forms.ListBox();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.personalNumbericalCodeLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Student);
            // 
            // enrolledCourseList
            // 
            this.enrolledCourseList.DataSource = this.studentCourseBindingSource;
            this.enrolledCourseList.FormattingEnabled = true;
            this.enrolledCourseList.Location = new System.Drawing.Point(400, 61);
            this.enrolledCourseList.Name = "enrolledCourseList";
            this.enrolledCourseList.Size = new System.Drawing.Size(305, 147);
            this.enrolledCourseList.TabIndex = 11;
            // 
            // studentCourseBindingSource
            // 
            this.studentCourseBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Course);
            // 
            // enrolledCoursesLabel
            // 
            this.enrolledCoursesLabel.AutoSize = true;
            this.enrolledCoursesLabel.Location = new System.Drawing.Point(400, 30);
            this.enrolledCoursesLabel.Name = "enrolledCoursesLabel";
            this.enrolledCoursesLabel.Size = new System.Drawing.Size(88, 13);
            this.enrolledCoursesLabel.TabIndex = 12;
            this.enrolledCoursesLabel.Text = "Enrolled courses:";
            // 
            // availableCoursesLabel
            // 
            this.availableCoursesLabel.AutoSize = true;
            this.availableCoursesLabel.Location = new System.Drawing.Point(397, 233);
            this.availableCoursesLabel.Name = "availableCoursesLabel";
            this.availableCoursesLabel.Size = new System.Drawing.Size(93, 13);
            this.availableCoursesLabel.TabIndex = 13;
            this.availableCoursesLabel.Text = "Available courses:";
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(713, 125);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(82, 23);
            this.leaveButton.TabIndex = 14;
            this.leaveButton.Text = "Leave Course";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // availableCourseList
            // 
            this.availableCourseList.DataSource = this.availableCourseBindingSource;
            this.availableCourseList.FormattingEnabled = true;
            this.availableCourseList.Location = new System.Drawing.Point(403, 266);
            this.availableCourseList.Name = "availableCourseList";
            this.availableCourseList.Size = new System.Drawing.Size(302, 160);
            this.availableCourseList.TabIndex = 15;
            this.availableCourseList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // availableCourseBindingSource
            // 
            this.availableCourseBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Course);
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(713, 335);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(75, 23);
            this.enrollButton.TabIndex = 16;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // gradeListBox
            // 
            this.gradeListBox.DataSource = this.gradeBindingSource;
            this.gradeListBox.FormattingEnabled = true;
            this.gradeListBox.Location = new System.Drawing.Point(840, 61);
            this.gradeListBox.Name = "gradeListBox";
            this.gradeListBox.Size = new System.Drawing.Size(284, 368);
            this.gradeListBox.TabIndex = 17;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Grade);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(837, 30);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(44, 13);
            this.gradeLabel.TabIndex = 18;
            this.gradeLabel.Text = "Grades:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Name", true));
            this.textBox1.Location = new System.Drawing.Point(152, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(12, 107);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(39, 13);
            this.groupLabel.TabIndex = 2;
            this.groupLabel.Text = "Group:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Group", true));
            this.textBox2.Location = new System.Drawing.Point(152, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 3;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(12, 177);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.cardNumberLabel.TabIndex = 4;
            this.cardNumberLabel.Text = "Card number:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "CardNumber", true));
            this.textBox3.Location = new System.Drawing.Point(152, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 20);
            this.textBox3.TabIndex = 5;
            // 
            // personalNumbericalCodeLabel
            // 
            this.personalNumbericalCodeLabel.AutoSize = true;
            this.personalNumbericalCodeLabel.Location = new System.Drawing.Point(12, 233);
            this.personalNumbericalCodeLabel.Name = "personalNumbericalCodeLabel";
            this.personalNumbericalCodeLabel.Size = new System.Drawing.Size(126, 13);
            this.personalNumbericalCodeLabel.TabIndex = 6;
            this.personalNumbericalCodeLabel.Text = "Personal numerical code:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "PersonalNumericalCode", true));
            this.textBox4.Location = new System.Drawing.Point(152, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 20);
            this.textBox4.TabIndex = 7;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 312);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.textBox5.Location = new System.Drawing.Point(152, 305);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 20);
            this.textBox5.TabIndex = 9;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(279, 372);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UpdateForm";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeListBox);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.availableCourseList);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.availableCoursesLabel);
            this.Controls.Add(this.enrolledCoursesLabel);
            this.Controls.Add(this.enrolledCourseList);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.personalNumbericalCodeLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameLabel);
            this.Name = "StudentForm";
            this.Text = "Student management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ListBox enrolledCourseList;
        private System.Windows.Forms.BindingSource studentCourseBindingSource;
        private System.Windows.Forms.Label enrolledCoursesLabel;
        private System.Windows.Forms.Label availableCoursesLabel;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.ListBox availableCourseList;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.BindingSource availableCourseBindingSource;
        private System.Windows.Forms.ListBox gradeListBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label personalNumbericalCodeLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button updateButton;
    }
}