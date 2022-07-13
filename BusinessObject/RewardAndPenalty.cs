using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class RewardAndPenalty
    {
        [Range(1, 1000, ErrorMessage = "ID Reward and penalty from 1 to 1000")]
        public int IdRp { get; set; }
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Reason are between 3 and 28 characters long")]
        public string Reason { get; set; }
        public DateTime? ApplicableDate { get; set; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Time contain only number")]
        public int? Times { get; set; }
        public int? IdReg { get; set; }
        public int? IdEmp { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
        public virtual Regulation IdRegNavigation { get; set; }
    }
}
