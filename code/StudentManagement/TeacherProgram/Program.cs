using System;
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

            var studentBll = container.Resolve<StudentBll>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var teacherForm = container.Resolve<TeacherEditView>();
            Application.Run(teacherForm);
        }
    }
}
