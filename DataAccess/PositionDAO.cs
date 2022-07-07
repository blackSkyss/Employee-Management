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

        public static void UpdateCertificate(Position p)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Entry<Position>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not update Position!!!");
            }
        }

        public static void DeletePosition(Position c)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    var c1 = db.Positions.SingleOrDefault(d => d.IdPos == c.IdPos);
                    db.Positions.Remove(c1);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Can not delete Position!!!");
            }
        }

        public static void InsertPosition(Position p)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Positions.Add(p);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not insert new Position!!!");
            }
        }

        public static Position GetPosByID(int id)
        {
            var pos = new Position();
            try
            {
                using (var db = new PRN211Context())
                {
                    pos = db.Positions.SingleOrDefault(c => c.IdPos == id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this Position by id!!!");
            }
            return pos;
        }
    }
}
