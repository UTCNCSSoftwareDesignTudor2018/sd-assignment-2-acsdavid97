using System;
using System.Linq;
using MongoDB.Driver;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Reporting
{
    public class StudentReportGenerator : IDisposable
    {
        private readonly IStudentReportBuilder _reportBuilder;

        public StudentReportGenerator(IStudentReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }

        public void GenerateReport(Student student, DateTime startDate, DateTime endDate)
        {
            var reportBody = _reportBuilder.CreateReportFor(student);
            var filteredGrades = student.Grades.Where(g => startDate < g.DateGraded && g.DateGraded < endDate);
            foreach (var grade in filteredGrades)
            {
                reportBody.AddGrade(grade);
            }

            reportBody.CloseBody();
        }

        public void Dispose()
        {
            _reportBuilder?.Dispose();
        }

        public static StudentReportGenerator CreatePdfGenerator(string path)
        {
            return new StudentReportGenerator(new StudentPdfReportBuilder(path));
        }

        public static StudentReportGenerator CreateMongoDbGenerator()
        {
            return new StudentReportGenerator(new MongoDbStudentReportBuilder(new MongoDbReportRepository(new MongoClient())));
        }
    }
}