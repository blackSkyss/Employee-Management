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
        [Range(1, 1000, ErrorMessage = "ID regulation from 1 to 1000")]
        public int IdReg { get; set; }
        [RegularExpression(@"[a-zA-Z][a-zA-Z ]*", ErrorMessage = "Name consist only of letters and space")]
        [StringLength(28, MinimumLength = 3, ErrorMessage = "Name are between 3 and 28 characters long")]
        public string Name { get; set; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Status contain only number")]
        public int? Status { get; set; }

        public virtual ICollection<RewardAndPenalty> RewardAndPenalties { get; set; }
    }
}
