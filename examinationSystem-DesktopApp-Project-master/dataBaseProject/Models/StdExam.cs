using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class StdExam
    {
        public string StdId { get; set; } = null!;
        public int ExamId { get; set; }
        public int FinalMark { get; set; }
        public bool Passed { get; set; }

        public virtual Exam Exam { get; set; } = null!;
        public virtual User Std { get; set; } = null!;
    }
}
