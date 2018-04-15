using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;
using Unity;

namespace TeacherProgram
{
    public static class ContainerConfiguration
    {
        public static UnityContainer SetupUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterInstance<IUniversityDbContext>(new UniversityDbContext());
            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ITeacherRepository, TeacherRepository>();

            return container;
        }
    }
}