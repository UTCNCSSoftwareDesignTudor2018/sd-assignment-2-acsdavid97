﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using StudentManagement.Reporting;
using TeacherProgram.Presentation.View;

namespace TeacherProgram.Presentation.Presenter
{
    internal class StudentEditPresenter
    {
        private readonly StudentEditView _studentEditView;
        private readonly StudentBll _studentBll;

        public StudentEditPresenter(StudentEditView studentEditView, StudentBll studentBll)
        {
            this._studentEditView = studentEditView;
            _studentBll = studentBll;

            UpdateForm();
        }

        internal void UpdateForm()
        {
            _studentEditView.LoadStudents(_studentBll.GetStudents());

            var student = _studentEditView.SelectedStudent;
            if (student == null)
            {
                return;
            }
            _studentEditView.LoadStudentCourses(student.Courses.ToList());
            _studentEditView.LoadStudentGrades(student.Grades.ToList());
        }

        public void UpdateStudent(Student student)
        {
            _studentBll.UpdateStudent(student);

            UpdateForm();
        }

        public void AddStudent(Student student)
        {
            student.Courses = new List<Course>();
            student.Grades = new List<Grade>();
            _studentBll.AddStudent(student);

            UpdateForm();
        }

        public void DeleteStudent(Student student)
        {
            _studentBll.DeleteStudent(student);

            UpdateForm();
        }

        public void StudentSelected(Student student)
        {
            _studentEditView.LoadStudentCourses(student.Courses.ToList());
            _studentEditView.LoadStudentGrades(student.Grades.ToList());
        }

        public void GenerateReport(Student student)
        {
            using (var studentGenerateDialog = new GenerateStudentReportDialog())
            {
                var result = studentGenerateDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var startDate = studentGenerateDialog.GetStartDate();
                    var endDate = studentGenerateDialog.GetEndDate();
                    using (var reportGenerator = CreateGenerator(studentGenerateDialog))
                    {
                        reportGenerator.GenerateReport(student, startDate, endDate);
                    }
                }
            }
        }

        public StudentReportGenerator CreateGenerator(GenerateStudentReportDialog dialog)
        {
            if (dialog.PdfSelected)
            {
                var filePath = dialog.GetPath();
                var reportGenerator = StudentReportGenerator.CreatePdfGenerator(filePath);
                return reportGenerator;
            }

            if (dialog.MongoDbSelected)
            {
                var reportGenerator = StudentReportGenerator.CreateMongoDbGenerator();
                return reportGenerator;
            }

            throw new InvalidOperationException();
        }

        public void GradeStudent(Student student, Course selectedStudentCourse, string markText)
        {
            if (selectedStudentCourse == null)
            {
                return;
            }

            var mark = int.Parse(markText);

            _studentBll.GradeStudent(student, selectedStudentCourse, mark);

            UpdateForm();
        }
    }
}