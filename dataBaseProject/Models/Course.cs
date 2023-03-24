using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class Course
    {
        public Course()
        {
            Exams = new HashSet<Exam>();
            Questions = new HashSet<Question>();
            Depts = new HashSet<Department>();
            Insts = new HashSet<User>();
            Stds = new HashSet<User>();
        }

        public int CrsId { get; set; }
        public string CrsName { get; set; } = null!;
        public int CrsDuration { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<Department> Depts { get; set; }
        public virtual ICollection<User> Insts { get; set; }
        public virtual ICollection<User> Stds { get; set; }
    }
}
