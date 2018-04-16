using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagement.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using StudentManagement.Business.Entity;
using StudentManagement.Reporting;

namespace StudentManagement.DataAccess.Repository.Tests
{
    [TestClass()]
    public class MongoDbReportRepositoryMongoTest
    {
        private MongoDbReportRepository _mongoRepo = new MongoDbReportRepository(new MongoClient());

        [TestMethod()]
        public void InsertTest()
        {
            _mongoRepo.Insert(new StudentReport
            {
                Grades = new List<ReportGrade>(),
                StudentId = 42
            });
        }
    }
}