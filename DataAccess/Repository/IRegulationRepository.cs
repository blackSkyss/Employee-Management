using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRegulationRepository
    {
        List<Regulation> GetRegulation();

        List<Regulation> GetRegulationByName(string name);
        List<Regulation> SearchRegulationById(string id);
        void InsertRegulation(Regulation reg);
        void UpdateRegulation(Regulation reg);
        void DeleteRegulation(Regulation reg);
        Regulation GetRegulationByID(int id);
        List<Regulation> FilterRegByStatus(string status);
    }
}
