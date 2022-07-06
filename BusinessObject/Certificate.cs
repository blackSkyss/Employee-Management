using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class Certificate
    {
        [Required]
        [Range(1, 1000, ErrorMessage = "ID from 1 to 1000")]
        public int CerId { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Names consist only of letters and space")]
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Names are between 3 and 28 characters long")]
        public string CerName { get; set; }

        [Required]
        public DateTime? Doi { get; set; }

        [Required]
        public int? IdEmp { get; set; }

        [Required]
        public int? IdTypeCer { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Employee IdEmpNavigation { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual TypeCertificate IdTypeCerNavigation { get; set; }
    }
}
