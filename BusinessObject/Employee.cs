using System;
using System.Collections.Generic;

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

        public int IdEmp { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string PhoneNum { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public int? BaseSalary { get; set; }
        public int? DepNum { get; set; }
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
