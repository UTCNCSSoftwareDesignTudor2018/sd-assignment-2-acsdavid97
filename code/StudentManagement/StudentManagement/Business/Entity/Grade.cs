using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Entity
{
    public class Grade
    {
        public int GradeId { get; set; }
        public virtual Student Student { get; set;} 
        public virtual Course Course { get; set; }
        public DateTime DateGraded { get; set; }
        public int Mark { get; set; }

        public override string ToString()
        {
            return $"{Course.Name} - {Mark} - {DateGraded}";
        }

        protected bool Equals(Grade other)
        {
            return Equals(Student, other.Student) && Equals(Course, other.Course) && DateGraded.Equals(other.DateGraded) && Mark == other.Mark;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Grade) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Student != null ? Student.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Course != null ? Course.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ DateGraded.GetHashCode();
                hashCode = (hashCode * 397) ^ Mark;
                return hashCode;
            }
        }
    }
}
