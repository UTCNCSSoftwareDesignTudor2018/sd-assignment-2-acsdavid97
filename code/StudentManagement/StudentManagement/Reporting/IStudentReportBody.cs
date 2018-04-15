using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    public interface IStudentReportBody
    {
        IStudentReportBody AddGrade(Grade grade);
        IStudentReportBuilder CloseBody();
    }
}