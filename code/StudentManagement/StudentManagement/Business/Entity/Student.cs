using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Business.Entity
{
    public class Student : User
    {
        public string Group { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }

        public void UnEnrollCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                throw new InvalidOperationException("Student is not enrolled in this course");
            }

            Courses.Remove(course);
        }

        public void EnrollCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                throw new InvalidOperationException("Student is already enrolled in this course");
            }

            Courses.Add(course);
        }
    }
}
