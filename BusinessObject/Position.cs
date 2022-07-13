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

        [Range(1, 1000, ErrorMessage = "ID position from 1 to 1000")]
        public int IdPos { get; set; }
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Position name consist only of letters and space")]
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Position name are between 3 and 28 characters long")]
        public string PosName { get; set; }
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Description are between 3 and 98 characters long")]
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Description consist only of letters and space")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
