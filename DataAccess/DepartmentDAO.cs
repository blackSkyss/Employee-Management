using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DepartmentDAO
    {
        //Get all department-------------------------------------------------------------------
        public static List<Department> GetDepartments()
        {
            var listDep = new List<Department>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listDep = db.Departments.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all department!!!");
            }

            return listDep;
        }

        //Get department by id--------------------------------------------------------------------
        public static Department GetDepartmentByID(int id)
        {
            Department dep = null;
            try
            {
                using (var db = new PRN211Context())
                {
                    dep = db.Departments.SingleOrDefault(d => d.DepNum == id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this department by id!!!");
            }

            return dep;
        }

        //Get department by name-------------------------------------------------------------------
        public static List<Department> GetDepartmentByName(string name)
        {
            var listDep = new List<Department>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listDep = db.Departments.Where(d => d.DepName.ToLower().Contains(name.ToLower())).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this department by name!!!");
            }

            return listDep;
        }

        //Search department by id--------------------------------------------------------------------
        public static List<Department> SearchDepartmentByID(string id)
        {
            var listDep = new List<Department>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listDep = db.Departments.Where(d => d.DepNum.ToString().Trim().Equals(id.Trim())).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not search this department by id!!!");
            }

            return listDep;
        }

        //Create department---------------------------------------------------------------------------
        public static void InsertDepartment(Department d)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Departments.Add(d);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not insert new department!!!");
            }
        }

        //Update department----------------------------------------------------------------------------
        public static void UpdateDepartment(Department d)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Entry<Department>(d).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not update department!!!");
            }
        }

        //Delete department----------------------------------------------------------------------------
        public static void DeleteDepartment(Department d)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    var d1 = db.Departments.SingleOrDefault(c => c.DepNum == d.DepNum);
                    db.Departments.Remove(d1);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not delete department!!!");
            }
        }
    }
}
