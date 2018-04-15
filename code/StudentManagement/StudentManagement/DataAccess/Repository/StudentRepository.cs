using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using StudentManagement.Business.Entity;

namespace StudentManagement.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IUniversityDbContext _universityDbContext;

        public StudentRepository(IUniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public Student Get(Student toGet)
        {
            return Get(toGet.UserId);
        }

        public Student Get(int id)
        {
            return _universityDbContext.Students.First(s => s.UserId == id);
        }

        public IList<Student> GetAll()
        {
            return _universityDbContext.Students.ToList();
        }

        public void Insert(Student toInsert)
        {
            _universityDbContext.Students.Add(toInsert);
            _universityDbContext.SaveChanges();
        }

        public void Update(Student toUpdate)
        {
            _universityDbContext.Students.AddOrUpdate(toUpdate);
            _universityDbContext.SaveChanges();
        }

        public void Delete(Student toDelete)
        {
            _universityDbContext.Students.Remove(toDelete);
            _universityDbContext.SaveChanges();
        }
    }
}