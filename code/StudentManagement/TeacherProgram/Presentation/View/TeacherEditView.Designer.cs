namespace TeacherProgram.Presentation.View
{
    partial class TeacherEditView
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
            this.teacherView = new System.Windows.Forms.DataGridView();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalNumericalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addressText = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.pncText = new System.Windows.Forms.TextBox();
            this.personalNumbericalCodeLabel = new System.Windows.Forms.Label();
            this.cardText = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.coursesTableAdapter1 = new StudentManagement.UniversityDbDataSetTableAdapters.CoursesTableAdapter();
            this.teacherBinding = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherListBinding = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherView
            // 
            this.teacherView.AutoGenerateColumns = false;
            this.teacherView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.CardNumber,
            this.PersonalNumericalCode,
            this.Address});
            this.teacherView.DataSource = this.teacherListBinding;
            this.teacherView.Location = new System.Drawing.Point(72, 42);
            this.teacherView.MultiSelect = false;
            this.teacherView.Name = "teacherView";
            this.teacherView.ReadOnly = true;
            this.teacherView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherView.Size = new System.Drawing.Size(454, 186);
            this.teacherView.TabIndex = 3;
            this.teacherView.SelectionChanged += new System.EventHandler(this.teacherView_SelectionChanged);
            // 
            // CardNumber
            // 
            this.CardNumber.DataPropertyName = "CardNumber";
            this.CardNumber.HeaderText = "CardNumber";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ReadOnly = true;
            // 
            // PersonalNumericalCode
            // 
            this.PersonalNumericalCode.DataPropertyName = "PersonalNumericalCode";
            this.PersonalNumericalCode.HeaderText = "PersonalNumericalCode";
            this.PersonalNumericalCode.Name = "PersonalNumericalCode";
            this.PersonalNumericalCode.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // courseView
            // 
            this.courseView.AutoGenerateColumns = false;
            this.courseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.teacherDataGridViewTextBoxColumn});
            this.courseView.DataSource = this.courseBindingSource;
            this.courseView.Location = new System.Drawing.Point(72, 263);
            this.courseView.Name = "courseView";
            this.courseView.Size = new System.Drawing.Size(257, 186);
            this.courseView.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(827, 300);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 23);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Delete Teacher";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(682, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 23);
            this.addButton.TabIndex = 35;
            this.addButton.Text = "Add Teacher";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(954, 300);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 23);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "Update Teacher";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addressText
            // 
            this.addressText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBinding, "Address", true));
            this.addressText.Location = new System.Drawing.Point(827, 233);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(192, 20);
            this.addressText.TabIndex = 33;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(687, 240);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 32;
            this.addressLabel.Text = "Address:";
            // 
            // pncText
            // 
            this.pncText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBinding, "PersonalNumericalCode", true));
            this.pncText.Location = new System.Drawing.Point(827, 154);
            this.pncText.Name = "pncText";
            this.pncText.Size = new System.Drawing.Size(192, 20);
            this.pncText.TabIndex = 31;
            // 
            // personalNumbericalCodeLabel
            // 
            this.personalNumbericalCodeLabel.AutoSize = true;
            this.personalNumbericalCodeLabel.Location = new System.Drawing.Point(687, 161);
            this.personalNumbericalCodeLabel.Name = "personalNumbericalCodeLabel";
            this.personalNumbericalCodeLabel.Size = new System.Drawing.Size(126, 13);
            this.personalNumbericalCodeLabel.TabIndex = 30;
            this.personalNumbericalCodeLabel.Text = "Personal numerical code:";
            // 
            // cardText
            // 
            this.cardText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBinding, "CardNumber", true));
            this.cardText.Location = new System.Drawing.Point(827, 98);
            this.cardText.Name = "cardText";
            this.cardText.Size = new System.Drawing.Size(192, 20);
            this.cardText.TabIndex = 29;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(687, 105);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.cardNumberLabel.TabIndex = 28;
            this.cardNumberLabel.Text = "Card number:";
            // 
            // nameText
            // 
            this.nameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBinding, "Name", true));
            this.nameText.Location = new System.Drawing.Point(827, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(192, 20);
            this.nameText.TabIndex = 25;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(687, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "Name:";
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // teacherBinding
            // 
            this.teacherBinding.DataSource = typeof(StudentManagement.Business.Entity.Teacher);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // teacherListBinding
            // 
            this.teacherListBinding.DataSource = typeof(StudentManagement.Business.Entity.Teacher);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Course);
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Grade);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentManagement.Business.Entity.Student);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.pncText);
            this.Controls.Add(this.personalNumbericalCodeLabel);
            this.Controls.Add(this.cardText);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.teacherView);
            this.Controls.Add(this.courseView);
            this.Name = "TeacherEditView";
            this.Text = "TeacherEditView";
            ((System.ComponentModel.ISupportInitialize)(this.teacherView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource teacherListBinding;
        private System.Windows.Forms.DataGridView teacherView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalNumericalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private StudentManagement.UniversityDbDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView courseView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox pncText;
        private System.Windows.Forms.Label personalNumbericalCodeLabel;
        private System.Windows.Forms.TextBox cardText;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource teacherBinding;
        private System.Windows.Forms.Button button1;
    }
}

