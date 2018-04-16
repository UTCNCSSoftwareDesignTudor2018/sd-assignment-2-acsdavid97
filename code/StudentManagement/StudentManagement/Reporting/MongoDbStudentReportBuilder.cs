using System.Collections.Generic;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Reporting
{
    class MongoDbStudentReportBuilder : IStudentReportBuilder
    {
        internal StudentReport StudentReport { get; private set; }
        private readonly IReportRepository _reportRepository;

        public MongoDbStudentReportBuilder(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public void Dispose()
        {
            _reportRepository.Insert(StudentReport);
        }

        public IStudentReportBody CreateReportFor(Student student)
        {
            StudentReport = new StudentReport
            {
                Student = student,
                Grades = new List<Grade>()
            };

            return new MongoDbStudentReportBody(this);
        }
    }
}
