﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Business;
using TeacherProgram.Presentation.View;
using Unity;

namespace TeacherProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = ContainerConfiguration.SetupUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, args) => MessageBox.Show(args.Exception.Message);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic); 

            var teacherForm = container.Resolve<HomeView>();
            Application.Run(teacherForm);
        }
    }
}
