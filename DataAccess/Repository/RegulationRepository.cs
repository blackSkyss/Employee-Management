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


        public List<Regulation> GetRegulation() => RegulationDAO.GetRegulation();

        public Regulation GetRegulationByID(int id) => RegulationDAO.GetRegByID(id);


        public List<Regulation> GetRegulationByName(string name)
        {
            throw new NotImplementedException();
        }

        public void InsertRegulation(Regulation reg) => RegulationDAO.InsertRegulation(reg);


        public void UpdateRegulation(Regulation reg) => RegulationDAO.UpdateRegulation(reg);

    }
}
