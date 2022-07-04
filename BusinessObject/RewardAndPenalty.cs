using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class RewardAndPenalty
    {
        public int IdRp { get; set; }
        public string Reason { get; set; }
        public DateTime? ApplicableDate { get; set; }
        public int? Times { get; set; }
        public int? IdReg { get; set; }
        public int? IdEmp { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
        public virtual Regulation IdRegNavigation { get; set; }
    }
}
