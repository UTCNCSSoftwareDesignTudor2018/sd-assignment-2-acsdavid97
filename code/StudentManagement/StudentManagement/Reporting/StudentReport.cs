﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    public class StudentReport
    {
        public int StudentId { get; set; }
        public IList<ReportGrade> Grades { get; set; }
    }
}
