using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    public class StudentReport
    {
        public ObjectId Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public IList<StudentReportGrade> Grades { get; set; }

        public override string ToString()
        {
            return $"{StudentId} - {StudentName} # {Grades.Count}";
        }
    }
}
