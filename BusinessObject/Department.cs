using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepNum { get; set; }
        public string DepName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
