using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CertificateRepository : ICertificateRepository
    {
        public void DeleteCertificate(Certificate certificate) => CertificateDAO.DeleteCertificate(certificate);

        public List<Certificate> GetAllCertificate() => CertificateDAO.GetCertificates();

        public List<TypeCertificate> GetAllTypeCerti() => CertificateDAO.GetTypeCertificates();
        public Certificate GetCertificateByID(int id) => CertificateDAO.GetCertificateByID(id);

        public List<Certificate> GetCertificateByIDEmp(int id) => CertificateDAO.GetCertificateByIDEmp(id);

        public List<Certificate> GetCertificateByName(string name) => CertificateDAO.GetCertificateByName(name);
        public void InsertCertificate(Certificate certificate) => CertificateDAO.InsertCertificate(certificate);

        public List<Certificate> SearchCertificateByID(string id) => CertificateDAO.SearchCertificateByID(id);

        public List<Certificate> FilterCertificateByIDType(string id) => CertificateDAO.FilterCertificateByIDType(id);

        public void UpdateCertificate(Certificate certificate) => CertificateDAO.UpdateCertificate(certificate);

        public List<Certificate> FilterCertificateByIDTypeEmp(string idtype, string idemp) => CertificateDAO.FilterCertificateByIDTypeEmp(idtype, idemp);

        public List<Certificate> SearchCertificateByNameCer(string namecer, string idemp) => CertificateDAO.SearchCertificateByNameCer(namecer, idemp);

        public List<Certificate> SearchCertificateByIDCer(string idcer, string idemp) => CertificateDAO.SearchCertificateByIDCer(idcer, idemp);
    }
}
