﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CertificateDAO
    {
        //Get all certificate------------------------------------------------------------------
        public static List<Certificate> GetCertificates()
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all certificate!!!");
            }

            return listCer;
        }

        //Get certificate by ID employee---------------------------------------------------------
        public static List<Certificate> GetCertificateByIDEmp(int id)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.IdEmp == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not find certificate by id employee!!!");
            }

            return listCer;
        }

        //Get all type of certificate------------------------------------------------------------
        public static List<TypeCertificate> GetTypeCertificates()
        {
            var listType = new List<TypeCertificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listType = db.TypeCertificates.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all type certificate!!!");
            }

            return listType;
        }

        //Get certificate by id------------------------------------------------------------------
        public static Certificate GetCertificateByID(int id)
        {
            var cer = new Certificate();
            try
            {
                using (var db = new PRN211Context())
                {
                    cer = db.Certificates.SingleOrDefault(c => c.CerId == id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this certificate by id!!!");
            }

            return cer;
        }

        //Get certificate by name-----------------------------------------------------------------
        public static List<Certificate> GetCertificateByName(string name)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.CerName.ToLower().Contains(name.ToLower())).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this certificate by name!!!");
            }

            return listCer;
        }

        //Insert certificate------------------------------------------------------------------------
        public static void InsertCertificate(Certificate c)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Certificates.Add(c);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not insert new certificate!!!");
            }
        }

        //Update certificate--------------------------------------------------------------------------
        public static void UpdateCertificate(Certificate c)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Entry<Certificate>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not update certificate!!!");
            }
        }

        //Delete certificate----------------------------------------------------------------------------
        public static void DeleteCertificate(Certificate c)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    var c1 = db.Certificates.SingleOrDefault(d => d.CerId == c.CerId);
                    db.Certificates.Remove(c1);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Can not delete certificate!!!");
            }
        }

        //Search certificate by id-------------------------------------------------------------------------
        public static List<Certificate> SearchCertificateByID(string id)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.CerId.ToString().Trim().Equals(id.Trim())).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not search this certificate by id!!!");
            }

            return listCer;
        }

        //Filter certificate by id type certificate-----------------------------------------------------------
        public static List<Certificate> FilterCertificateByIDType(string id)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.IdTypeCer.ToString().Trim().Equals(id.Trim())).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not filter certificate by id type!!!");
            }

            return listCer;
        }

        //Filter certificate role employee----------------------------------------------------------
        public static List<Certificate> FilterCertificateByIDTypeEmp(string idtype, string idemp)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.IdTypeCer.ToString().Equals(idtype)
                                                    && c.IdEmp.ToString().Equals(idemp)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not filter certificate by id type!!!");
            }

            return listCer;
        }

        //Search certificate by id role employee------------------------------------------------------
        public static List<Certificate> SearchCertificateByIDCer(string idcer, string idemp)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.CerId.ToString().Equals(idcer)
                                                    && c.IdEmp.ToString().Equals(idemp)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not filter certificate by id type!!!");
            }

            return listCer;
        }

        //Search certificate by name role employee------------------------------------------------------
        public static List<Certificate> SearchCertificateByNameCer(string namecer, string idemp)
        {
            var listCer = new List<Certificate>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listCer = db.Certificates.Where(c => c.CerName.ToLower().Contains(namecer.ToLower())
                                                    && c.IdEmp.ToString().Equals(idemp)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not filter certificate by id type!!!");
            }

            return listCer;
        }


    }
}
