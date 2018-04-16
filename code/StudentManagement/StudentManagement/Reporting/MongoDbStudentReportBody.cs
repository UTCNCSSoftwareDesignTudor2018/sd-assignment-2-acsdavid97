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
            _reportBuilder.StudentReport.Grades.Add(grade);
            return this;
        }

        public IStudentReportBuilder CloseBody()
        {
            return _reportBuilder;
        }
    }
}