using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPositionRepository
    {
        List<Position> GetPositions();

        Position GetPositionByID(int id);

        List<Position> GetPositionByName(string name);
        void InsertCertificate(Position p);
        void UpdateCertificate(Position p);
        void DeletePosition(Position p);
        Position GetPosByID(int id);

    }
}
