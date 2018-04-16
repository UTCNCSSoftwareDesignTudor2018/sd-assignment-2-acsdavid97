using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Reporting;

namespace StudentManagement.DataAccess.Repository
{
    public interface IReportRepository
    {
        void Insert(StudentReport studentReport);
        IList<StudentReport> GetAll();
    }
}
