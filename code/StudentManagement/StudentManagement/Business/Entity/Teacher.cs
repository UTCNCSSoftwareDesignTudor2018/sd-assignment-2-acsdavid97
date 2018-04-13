using System;
using System.Collections.Generic;

namespace StudentManagement.Business.Entity
{
    public class Teacher : User
    {
        public virtual ICollection<Course> Courses { get; set; }

        public void TeachCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                throw new InvalidOperationException("Teacher already teaching this course");
            }
            Courses.Add(course);
        }
    }
}