using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RegulationRepository : IRegulationRepository
    {
        public void DeleteRegulation(Regulation reg) => RegulationDAO.DeleteRegulation(reg);

        public List<Regulation> FilterRegByStatus(string status) => RegulationDAO.FilterRegByStatus(status);


        public List<Regulation> GetRegulation() => RegulationDAO.GetRegulation();

        public Regulation GetRegulationByID(int id) => RegulationDAO.GetRegByID(id);


        public List<Regulation> GetRegulationByName(string name) => RegulationDAO.GetRegulationByName(name);


        public void InsertRegulation(Regulation reg) => RegulationDAO.InsertRegulation(reg);

        public List<Regulation> SearchRegulationById(string id) => RegulationDAO.SearchPositionByID(id);


        public void UpdateRegulation(Regulation reg) => RegulationDAO.UpdateRegulation(reg);

    }
}
