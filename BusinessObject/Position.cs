using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdPos { get; set; }
        public string PosName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
