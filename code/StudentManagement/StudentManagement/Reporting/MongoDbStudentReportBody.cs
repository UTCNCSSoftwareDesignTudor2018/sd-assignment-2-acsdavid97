using System;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    class MongoDbStudentReportBody : IStudentReportBody
    {
        private readonly MongoDbStudentReportBuilder _reportBuilder;
        public MongoDbStudentReportBody(MongoDbStudentReportBuilder mongoDbStudentReportBuilder)
        {
            _reportBuilder = mongoDbStudentReportBuilder;
        }

        public IStudentReportBody AddGrade(Grade grade)
        {
            _reportBuilder.StudentReport.Grades.Add(new StudentReportGrade
            {
                CourseName = grade.Course.Name,
                DateTime = grade.DateGraded,
                Mark = grade.Mark
            });
            return this;
        }

        public IStudentReportBuilder CloseBody()
        {
            _reportBuilder.ReportRepository.Insert(_reportBuilder.StudentReport);
            return _reportBuilder;
        }
    }
}