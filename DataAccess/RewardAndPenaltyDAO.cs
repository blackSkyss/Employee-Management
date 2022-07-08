using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RewardAndPenaltyDAO
    {
        public static List<RewardAndPenalty> GetRP()
        {
            var listRP = new List<RewardAndPenalty>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listRP = db.RewardAndPenalties.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all RP!!!");
            }

            return listRP;
        }

        public static void UpdateRP(RewardAndPenalty rp)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Entry<RewardAndPenalty>(rp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not update Position!!!");
            }
        }

        public static void DeleteRP(RewardAndPenalty rp)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    var c1 = db.RewardAndPenalties.SingleOrDefault(d => d.IdRp == rp.IdRp);
                    db.RewardAndPenalties.Remove(c1);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Can not delete RP!!!");
            }
        }

        public static void InsertRP(RewardAndPenalty rp)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.RewardAndPenalties.Add(rp);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not insert new RP!!!");
            }
        }

        public static RewardAndPenalty GetRewardAndPenaltyByID(int id)
        {
            var rp = new RewardAndPenalty();
            try
            {
                using (var db = new PRN211Context())
                {
                    rp = db.RewardAndPenalties.SingleOrDefault(c => c.IdRp == id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this RP by id!!!");
            }
            return rp;
        }

        public static List<RewardAndPenalty> GetRewardAndPenaltieByIDEmp(int id)
        {
            var listRePe = new List<RewardAndPenalty>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listRePe = db.RewardAndPenalties.Where(r => r.IdEmp == id).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get reward and penalty by id employee!!!");
            }

            return listRePe;
        }
    }
}
