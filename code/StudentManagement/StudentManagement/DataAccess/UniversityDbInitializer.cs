using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business;
using StudentManagement.Business.Entity;

namespace StudentManagement.DataAccess
{
    public class UniversityDbInitializer : DropCreateDatabaseIfModelChanges<UniversityDbContext>
    {

        protected override void Seed(UniversityDbContext context)
        {

            IList<Teacher> defaultTeachers = new List<Teacher>();

            defaultTeachers.Add(new Teacher
            {
                Address = "Cluj-napoca whatever",
                CardNumber = "54322",
                Courses = new List<Course>(),
                Name = "Super teacher",
                PersonalNumericalCode = "43269"
            });

            defaultTeachers.Add(new Teacher
            {
                Address = "Cluj-napoca whatever",
                CardNumber = "54323",
                Courses = new List<Course>(),
                Name = "Uber teacher",
                PersonalNumericalCode = "43268"
            });

            context.Teachers.AddRange(defaultTeachers);

            IList<Course> defaultCourses = new List<Course>();

            defaultCourses.Add(new Course
            {
                Name = "Software Design",
                Teacher = defaultTeachers[0],
                Students = new List<Student>()
            });

            defaultCourses.Add(new Course
            {
                Name = "Formal Languages and Translators",
                Students = new List<Student>(),
                Teacher = defaultTeachers[1]
            });

            IList<Student> defaultStudents = new List<Student>();

            Student somebody = new Student
            {
                Address = "Wall street",
                CardNumber = "12345",
                Group = "30432",
                Name = "Somebody",
                PersonalNumericalCode = "35234",
                Courses = new List<Course>
                {
                    defaultCourses[0]
                },
                Grades = new List<Grade>(),
            };


            somebody.Grades.Add(new Grade
            {
                Course = defaultCourses[0],
                DateGraded = DateTime.Now,
                Mark = 10,
                Student = somebody,
            });

            defaultStudents.Add(somebody);

            defaultStudents.Add(new Student
            {
                Address = "Sesame street",
                CardNumber = "54312",
                Courses = new List<Course>(),
                Group = "30432",
                Name = "Anybody",
                PersonalNumericalCode = "34263",
            });

            defaultStudents.Add(new Student
            {
                Address = "Baker street",
                CardNumber = "25521",
                Courses = new List<Course>(),
                Group = "30434",
                Name = "Everybody",
                PersonalNumericalCode = "99999",
            });

            context.Students.AddRange(defaultStudents);

            context.Courses.AddRange(defaultCourses);
            context.SaveChanges();
        }
    }
}
