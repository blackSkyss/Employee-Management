﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RegulationDAO
    {
        public static List<Regulation> GetRegulation()
        {
            var listRegulation = new List<Regulation>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listRegulation = db.Regulations.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all Regulation!!!");
            }

            return listRegulation;
        }

        public static void UpdateRegulation(Regulation reg)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Entry<Regulation>(reg).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not update regulation!!!");
            }
        }

        public static void DeleteRegulation(Regulation reg)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    var c1 = db.Regulations.SingleOrDefault(d => d.IdReg == reg.IdReg);
                    db.Regulations.Remove(c1);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Can not delete regulation!!!");
            }
        }

        public static void InsertRegulation(Regulation reg)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Regulations.Add(reg);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not insert new regulation!!!");
            }
        }


        public static Regulation GetRegByID(int id)
        {
            var reg = new Regulation();
            try
            {
                using (var db = new PRN211Context())
                {
                    reg = db.Regulations.SingleOrDefault(c => c.IdReg == id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this regulation by id!!!");
            }
            return reg;
        }

        public static List<Regulation> GetRegulationByName(string name)
        {
            var listReg = new List<Regulation>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listReg = db.Regulations.Where(e => e.Name.ToLower().Contains(name.ToLower())).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this Regulation by name!!!");
            }

            return listReg;
        }

        public static List<Regulation> SearchPositionByID(string id)
        {
            var listReg = new List<Regulation>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listReg = db.Regulations.Where(e => e.IdReg.ToString().Contains(id)).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this Regulation by id!!!");
            }

            return listReg;
        }

        public static List<Regulation> FilterRegByStatus(string status)
        {
            var listReg = new List<Regulation>();
            try
            {
                using (var db = new PRN211Context())
                {
                    if (status.Equals("Reward"))
                    {
                        listReg = db.Regulations.Where(c => c.Status == 1).ToList();
                    }
                    else if(status.Equals("Penalty"))
                    {
                        listReg = db.Regulations.Where(c => c.Status == 0).ToList();
                    }
                    else if (status.Equals("All"))
                    {
                        listReg = db.Regulations.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not filter Regulation by id type!!!");
            }

            return listReg;
        }
    }
}
