using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICertificateRepository
    {
        List<Certificate> GetAllCertificate();

        List<TypeCertificate> GetAllTypeCerti();

        Certificate GetCertificateByID(int id);

        List<Certificate> GetCertificateByName(string name);

        void InsertCertificate(Certificate certificate);
        void UpdateCertificate(Certificate certificate);
        void DeleteCertificate(Certificate certificate);

        List<Certificate> GetCertificateByIDEmp(int id);

        List<Certificate> SearchCertificateByID(string id);

        List<Certificate> FilterCertificateByIDType(string id);

        //Role employee-----------------------------------------
        List<Certificate> FilterCertificateByIDTypeEmp(string idtype, string idemp);

        List<Certificate> SearchCertificateByNameCer(string namecer, string idemp);

        List<Certificate> SearchCertificateByIDCer(string idcer, string idemp);
    }
}
