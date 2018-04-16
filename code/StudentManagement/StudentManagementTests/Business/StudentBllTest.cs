using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagement.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using StudentManagement.Business.Entity;
using StudentManagement.Business.Validator;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Business.Tests
{
    [TestClass()]
    public class StudentBllTest
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            var studentRepo = new Mock<IStudentRepository>();
            var userValidator = new Mock<IGenericValidator<User>>();
            var studentBll = new StudentBll(studentRepo.Object, userValidator.Object);

            var student = new Student
            {
                Name = "Student",
                Address = "Address",
                CardNumber = "12345",
                Courses = new List<Course>(),
                Grades = new List<Grade>(),
                Group = "43214",
                PersonalNumericalCode = "12345",
            };

            studentBll.AddStudent(student);

            studentRepo.Verify(r => r.Insert(student));
            userValidator.Verify(uv => uv.Validate(student));
        }

        [TestMethod()]
        public void AddInvalidStudentTest()
        {
            var studentRepo = new Mock<IStudentRepository>();
            var userValidator = new UserValidator();
            var studentBll = new StudentBll(studentRepo.Object, userValidator);

            var student = new Student
            {
                Name = "", // invalid name
                Address = "Address",
                CardNumber = "12345",
                Courses = new List<Course>(),
                Grades = new List<Grade>(),
                Group = "43214",
                PersonalNumericalCode = "12345",
            };

            Assert.ThrowsException<ArgumentException>(() => studentBll.AddStudent(student));
        }
    }
}