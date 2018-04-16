using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    /// <summary>
    /// Report Builder for Student reports, should contain student and all of the selected grades of the student.
    /// </summary>
    public interface IStudentReportBuilder : IDisposable
    {
        IStudentReportBody CreateReportFor(Student student);
    }
}
