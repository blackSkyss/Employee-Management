using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Regulation
    {
        public Regulation()
        {
            RewardAndPenalties = new HashSet<RewardAndPenalty>();
        }

        public int IdReg { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<RewardAndPenalty> RewardAndPenalties { get; set; }
    }
}
