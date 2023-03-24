using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class User
    {
        public User()
        {
            StdExams = new HashSet<StdExam>();
            Crs = new HashSet<Course>();
            CrsNavigation = new HashSet<Course>();
        }

        public string Ssn { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Age { get; set; }
        public string Role { get; set; } = null!;
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; } = null!;
        public virtual ICollection<StdExam> StdExams { get; set; }

        public virtual ICollection<Course> Crs { get; set; }
        public virtual ICollection<Course> CrsNavigation { get; set; }
    }
}
