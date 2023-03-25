using System;
using System.Collections.Generic;

namespace dataBaseProject.Models
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
            Crs = new HashSet<Course>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Course> Crs { get; set; }
    }
}
