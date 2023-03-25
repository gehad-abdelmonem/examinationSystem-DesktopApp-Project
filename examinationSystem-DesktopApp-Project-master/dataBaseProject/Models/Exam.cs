using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class Exam
    {
        public Exam()
        {
            StdExams = new HashSet<StdExam>();
            Ques = new HashSet<Question>();
        }

        public int ExamId { get; set; }
        public int Grade { get; set; }
        public int CrsId { get; set; }

        public virtual Course Crs { get; set; } = null!;
        public virtual ICollection<StdExam> StdExams { get; set; }

        public virtual ICollection<Question> Ques { get; set; }
    }
}
