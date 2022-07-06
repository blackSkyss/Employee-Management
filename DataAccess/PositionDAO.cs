using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PositionDAO
    {
        //Get all position--------------------------------------------------------------------
        public static List<Position> GetPositions()
        {
            var listPos = new List<Position>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listPos = db.Positions.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all position!!!");
            }

            return listPos;
        }
    }
}
