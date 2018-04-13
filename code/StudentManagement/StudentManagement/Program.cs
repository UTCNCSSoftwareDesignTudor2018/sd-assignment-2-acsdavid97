﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using StudentManagement.Business;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;
using StudentManagement.Presentation.View;
using Unity;

namespace StudentManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer();
            container.RegisterInstance<IUniversityDbContext>(new UniversityDbContext());
            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();

            Database.SetInitializer(new UniversityDbInitializer());

            var studentRepository = container.Resolve<IStudentRepository>();
            var student = studentRepository.GetAll().First();

            var studentBll = container.Resolve<StudentBll>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentForm(student, studentBll));
        }
    }
}