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

        public List<RewardAndPenalty> GetRewardAndPenaltieByIDEmp(int id) => RewardAndPenaltyDAO.GetRewardAndPenaltieByIDEmp(id);

        public List<RewardAndPenalty> GetRewardAndPenalty() => RewardAndPenaltyDAO.GetRP();


        public RewardAndPenalty GetRewardAndPenaltyByID(int id) => RewardAndPenaltyDAO.GetRewardAndPenaltyByID(id);


        public List<RewardAndPenalty> GetRewardAndPenaltyByName(string name)
        {
            throw new NotImplementedException();
        }



        public void InsertRewardAndPenalty(RewardAndPenalty p) => RewardAndPenaltyDAO.InsertRP(p);

        public List<RewardAndPenalty> SearchRewardAndPenaltieByIDEmp(string id) =>RewardAndPenaltyDAO.SearchRewardAndPenaltyByIDEmp(id);

        public List<RewardAndPenalty> SearchRewardAndPenaltieByIDReg(string id) =>RewardAndPenaltyDAO.SearchRewardAndPenaltyByIDReg(id);

        public List<RewardAndPenalty> SearchRewardAndPenaltyByIDReEmp(string idre, string idemp) => RewardAndPenaltyDAO.SearchRewardAndPenaltyByIDReEmp(idre, idemp);

        public List<RewardAndPenalty> SearchRewardAndPenaltyByIDRegEmp(string idreg, string idemp) => RewardAndPenaltyDAO.SearchRewardAndPenaltyByIDRegEmp(idreg, idemp);   
        public List<RewardAndPenalty> SearchRewardAndPenaltyByIdRP(string id) => RewardAndPenaltyDAO.SearchRPByID(id);
        

        public void UpdateRewardAndPenalty(RewardAndPenalty p) => RewardAndPenaltyDAO.UpdateRP(p);


        


    }
}
