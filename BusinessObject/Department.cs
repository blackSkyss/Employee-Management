using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        [Required]
        [Range(1, 1000, ErrorMessage = "ID from 1 to 1000")]
        public int DepNum { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Names consist only of letters and space")]
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Names are between 3 and 28 characters long")]
        public string DepName { get; set; }

        [Required]
        [StringLength(48, MinimumLength = 3, ErrorMessage = "Description are between 3 and 48 characters long")]
        public string Description { get; set; }

        [Required]
        [StringLength(48, MinimumLength = 3, ErrorMessage = "Description are between 3 and 28 characters long")]
        public string Location { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
