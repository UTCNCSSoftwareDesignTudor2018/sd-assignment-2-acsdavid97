using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    /// <summary>
    /// Body (list or table) of the student report, the grades of the student.
    /// </summary>
    public interface IStudentReportBody
    {
        IStudentReportBody AddGrade(Grade grade);
        IStudentReportBuilder CloseBody();
    }
}