using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class QuesChoice
    {
        public int QuesId { get; set; }
        public string QuesChoice1 { get; set; } = null!;

        public virtual Question Ques { get; set; } = null!;
    }
}
