using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagement.DataAccess;

namespace StudentManagementTest
{
    [TestClass]
    public class DbTest
    {
        [TestMethod]
        public void TestConnection()
        {
            using (var ctx = new UniversityDbContext())
            {
                Assert.AreEqual(ctx.Courses.Count(), 2);
            }
        }
    }
}
