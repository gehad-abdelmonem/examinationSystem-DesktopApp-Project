using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class Question
    {
        public Question()
        {
            QuesChoices = new HashSet<QuesChoice>();
            Exams = new HashSet<Exam>();
        }

        public int QuesId { get; set; }
        public int? CrsId { get; set; }
        public string? Body { get; set; }
        public string ModelAnswer { get; set; } = null!;
        public int Mark { get; set; }
        public string Type { get; set; } = null!;

        public virtual Course? Crs { get; set; }
        public virtual ICollection<QuesChoice> QuesChoices { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
