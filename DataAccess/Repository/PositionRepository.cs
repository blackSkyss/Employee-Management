using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PositionRepository : IPositionRepository
    {
        public void DeletePosition(Position p) => PositionDAO.DeletePosition(p);

        public Position GetPosByID(int id) => PositionDAO.GetPosByID(id);
        

        public Position GetPositionByID(int id) => PositionDAO.GetPosByID(id);



        public List<Position> GetPositionByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetPositions() => PositionDAO.GetPositions();
        public void InsertCertificate(Position p) => PositionDAO.InsertPosition(p);
        public void UpdateCertificate(Position p) => PositionDAO.UpdateCertificate(p);

    }
}
