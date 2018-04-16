using System.Collections.Generic;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Reporting
{
    class MongoDbStudentReportBuilder : IStudentReportBuilder
    {
        internal StudentReport StudentReport { get; private set; }
        internal readonly IReportRepository ReportRepository;

        public MongoDbStudentReportBuilder(IReportRepository reportRepository)
        {
            ReportRepository = reportRepository;
        }

        public void Dispose()
        {
        }

        public IStudentReportBody CreateReportFor(Student student)
        {
            StudentReport = new StudentReport
            {
                StudentId = student.UserId,
                StudentName = student.Name,
                Grades = new List<StudentReportGrade>()
            };

            return new MongoDbStudentReportBody(this);
        }
    }
}
