using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    public interface IStudentReportBuilder : IDisposable
    {
        IStudentReportBody CreateReportFor(Student student);
    }
}
