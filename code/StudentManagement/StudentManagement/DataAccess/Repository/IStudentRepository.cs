using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;

namespace StudentManagement.DataAccess.Repository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        void InsertCourseOfStudent(Student student, Course course);
        void DeleteCourseOfStudent(Student student, Course course);
    }
}
