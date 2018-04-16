using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Business;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;
using StudentProgram.Presentation.View;
using Unity;

namespace StudentProgram
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

            Database.SetInitializer(new UniversityDbInitializer());

            var studentRepository = container.Resolve<IStudentRepository>();
            var student = studentRepository.GetAll().First();

            Application.ThreadException += (sender, args) => MessageBox.Show(args.Exception.Message);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic); 

            var studentBll = container.Resolve<StudentBll>();
            var courseBll = container.Resolve<CourseBll>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentForm(student, studentBll, courseBll));
        }

    }
}
