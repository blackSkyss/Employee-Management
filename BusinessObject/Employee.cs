using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class Employee
    {
        public Employee()
        {
            Certificates = new HashSet<Certificate>();
            RewardAndPenalties = new HashSet<RewardAndPenalty>();
        }


        [Required]
        [Range(1, 1000, ErrorMessage = "ID from 1 to 1000")]
        public int IdEmp { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Names consist only of letters and space")]
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Names are between 3 and 28 characters long")]
        public string Name { get; set; }

        [Required]
        [StringLength(48, MinimumLength = 3, ErrorMessage = "Address are between 3 and 48 characters long")]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone contain only number")]
        [StringLength(13, MinimumLength = 5, ErrorMessage = "Phone are between 5 and 13 characters long")]
        public string PhoneNum { get; set; }

        [Required]
        public DateTime? Dob { get; set; }

        [Required]
        public DateTime? JoinDate { get; set; }

        [Required]
        [StringLength(28, ErrorMessage = "Email length must not exceed 28 characters")]
        [RegularExpression(@"^[\w.+\-]+@gmail\.com$", ErrorMessage = "Enter the email address in the format someone@gmail.com")]
        public string Email { get; set; }

        [Required]
        [StringLength(28, MinimumLength = 6, ErrorMessage = "Password length from 6 to 28 characters")]
        public string Password { get; set; }

        [Required]
        public int? Role { get; set; }

        [Required]
        [Range(1000000, 100000000, ErrorMessage = "Salary from 1.000.000 to 100.000.000")]
        public int? BaseSalary { get; set; }

        [Required]
        public int? DepNum { get; set; }

        [Required]
        public int? IdPos { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Department DepNumNavigation { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Position IdPosNavigation { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Certificate> Certificates { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<RewardAndPenalty> RewardAndPenalties { get; set; }
    }
}
