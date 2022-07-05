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

        public List<Certificate> GetCertificateByName(string name) => CertificateDAO.GetCertificateByName(name);
        public void InsertCertificate(Certificate certificate) => CertificateDAO.InsertCertificate(certificate);

        public void UpdateCertificate(Certificate certificate) => CertificateDAO.UpdateCertificate(certificate);
    }
}
