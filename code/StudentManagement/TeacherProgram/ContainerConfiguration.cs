using MongoDB.Driver;
using StudentManagement.Business.Entity;
using StudentManagement.Business.Validator;
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
            container.RegisterInstance<IReportRepository>(new MongoDbReportRepository(new MongoClient()));

            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<ITeacherRepository, TeacherRepository>();
            container.RegisterType<IGenericValidator<User>, UserValidator>();

            return container;
        }
    }
}