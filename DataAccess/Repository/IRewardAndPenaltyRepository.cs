using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRewardAndPenaltyRepository
    {
        List<RewardAndPenalty> GetRewardAndPenalty();
        RewardAndPenalty GetRewardAndPenaltyByID(int id);

        List<RewardAndPenalty> GetRewardAndPenaltyByName(string name);

        

        List<RewardAndPenalty> SearchRewardAndPenaltyByIdRP(string id);
        List<RewardAndPenalty> GetRewardAndPenaltieByIDEmp(int id);
        List<RewardAndPenalty> SearchRewardAndPenaltieByIDEmp(string id);
        List<RewardAndPenalty> SearchRewardAndPenaltieByIDReg(string id);

        void InsertRewardAndPenalty(RewardAndPenalty p);
        void UpdateRewardAndPenalty(RewardAndPenalty p);
        void DeleteRewardAndPenalty(RewardAndPenalty p);

        //Role employee-----------------------------------------------------------------------

        List<RewardAndPenalty> SearchRewardAndPenaltyByIDReEmp(string idre, string idemp);
        List<RewardAndPenalty> SearchRewardAndPenaltyByIDRegEmp(string idreg, string idemp);


    }
}
