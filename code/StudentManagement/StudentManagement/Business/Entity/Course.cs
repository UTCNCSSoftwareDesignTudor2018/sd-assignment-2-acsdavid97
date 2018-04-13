using System.Collections.Generic;

namespace StudentManagement.Business.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Teacher}";
        }

        protected bool Equals(Course other)
        {
            return CourseId == other.CourseId && string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Course) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = CourseId;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
