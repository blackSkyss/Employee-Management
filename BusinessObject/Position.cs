using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Position name consist only of letters and space")]
        public string PosName { get; set; }
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Description consist only of letters and space")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
