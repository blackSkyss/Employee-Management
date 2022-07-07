using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RegulationDAO
    {
        public static List<Regulation> GetRegulation()
        {
            var listRegulation = new List<Regulation>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listRegulation = db.Regulations.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all Regulation!!!");
            }

            return listRegulation;
        }
    }
}
