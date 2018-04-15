using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Business.Entity;
using StudentManagement.DataAccess;
using StudentManagement.DataAccess.Repository;

namespace StudentManagement.DataAccess.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly IUniversityDbContext _universityDbContext;

        public TeacherRepository(IUniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public Teacher Get(Teacher toGet)
        {
            return Get(toGet.UserId);
        }

        public Teacher Get(int id)
        {
            return _universityDbContext.Teachers.First(s => s.UserId == id);
        }

        public IList<Teacher> GetAll()
        {
            return _universityDbContext.Teachers.ToList();
        }

        public void Insert(Teacher toInsert)
        {
            _universityDbContext.Teachers.Add(toInsert);
            _universityDbContext.SaveChanges();
        }

        public void Update(Teacher toUpdate)
        {
            _universityDbContext.Teachers.AddOrUpdate(toUpdate);
            _universityDbContext.SaveChanges();
        }

        public void Delete(Teacher toDelete)
        {
            _universityDbContext.Teachers.Remove(toDelete);
            _universityDbContext.SaveChanges();
        }
    }
}
