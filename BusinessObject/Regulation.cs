using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BusinessObject
{
    public partial class Regulation
    {
        public Regulation()
        {
            RewardAndPenalties = new HashSet<RewardAndPenalty>();
        }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "ID regulation contain only number")]
        public int IdReg { get; set; }
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Name consist only of letters and space")]
        public string Name { get; set; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Status contain only number")]
        public int? Status { get; set; }

        public virtual ICollection<RewardAndPenalty> RewardAndPenalties { get; set; }
    }
}
