using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RewardAndPenaltyRepository : IRewardAndPenaltyRepository
    {
        public void DeleteRewardAndPenalty(RewardAndPenalty p) => RewardAndPenaltyDAO.DeleteRP(p);


        public List<RewardAndPenalty> GetRewardAndPenalty() => RewardAndPenaltyDAO.GetRP();


        public RewardAndPenalty GetRewardAndPenaltyByID(int id) => RewardAndPenaltyDAO.GetRewardAndPenaltyByID(id);


        public List<RewardAndPenalty> GetRewardAndPenaltyByName(string name)
        {
            throw new NotImplementedException();
        }

        public void InsertRewardAndPenalty(RewardAndPenalty p) => RewardAndPenaltyDAO.InsertRP(p);


        public void UpdateRewardAndPenalty(RewardAndPenalty p)=> RewardAndPenaltyDAO.UpdateRP(p);
        
    }
}
