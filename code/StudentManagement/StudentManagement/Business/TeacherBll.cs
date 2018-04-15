using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Business
{
    public class TeacherBll
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherBll(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IList<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAll();
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.Insert(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
    }
}
