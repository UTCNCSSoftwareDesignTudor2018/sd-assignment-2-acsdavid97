using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;
using StudentManagement.Business.Validator;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.Business
{
    /// <summary>
    /// Business operations related to Teachers.
    /// </summary>
    public class TeacherBll
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IGenericValidator<User> _userValidator;

        public TeacherBll(ITeacherRepository teacherRepository, IGenericValidator<User> userValidator)
        {
            _teacherRepository = teacherRepository;
            _userValidator = userValidator;
        }

        public IList<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAll();
        }

        public void AddTeacher(Teacher teacher)
        {
            _userValidator.Validate(teacher);
            _teacherRepository.Insert(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _userValidator.Validate(teacher);
            _teacherRepository.Update(teacher);
        }
    }
}
