using StudentManagement.Business.Entity;
using StudentManagement.Business.Validator;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;
using Unity;

namespace StudentProgram
{
    public static class ContainerConfiguration
    {
        public static UnityContainer SetupUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterInstance<IUniversityDbContext>(new UniversityDbContext());
            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IGenericValidator<User>, UserValidator>();

            return container;
        }
    }
}