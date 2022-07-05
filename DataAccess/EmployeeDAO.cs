using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDAO
    {
        //Get all member------------------------------------------------------------------------
        public static List<Employee> GetAllEmpoyee()
        {
            var listEmployee = new List<Employee>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listEmployee = db.Employees.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not get all employee!!!");
            }
            return listEmployee;
        }

        //Login-----------------------------------------------------------------------------------
        public static Employee Login(string email, string password)
        {
            Employee emp = null;
            try
            {
                using (var db = new PRN211Context())
                {
                    emp = db.Employees.SingleOrDefault(e => e.Email.Equals(email) && e.Password.Equals(password));
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not login!!!");
            }

            return emp;
        }

        //Get employee by id-----------------------------------------------------------------------
        public static Employee GetEmployeeByID(int id)
        {
            Employee emp = null;
            try
            {
                using (var db = new PRN211Context())
                {
                    emp = db.Employees.SingleOrDefault(e => e.IdEmp == id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this employee by id!!!");
            }

            return emp;
        }

        //Get employee by name-----------------------------------------------------------------------
        public static List<Employee> GetEmployeeByName(string name)
        {
            var listEmp = new List<Employee>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listEmp = db.Employees.Where(e => e.Name.ToLower().Contains(name.ToLower())).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this employee by name!!!");
            }

            return listEmp;
        }

        //Get employee by email------------------------------------------------------------------------
        public static List<Employee> GetEmployeeByEmail(string email)
        {
            var listEmp = new List<Employee>();
            try
            {
                using (var db = new PRN211Context())
                {
                    listEmp = db.Employees.Where(e => e.Email.ToLower().Contains(email.ToLower())).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not find this meployee by email!!!");
            }

            return listEmp;
        }

        //Create new employee----------------------------------------------------------------------------
        public static void InsertEmployee(Employee e)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Employees.Add(e);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not insert new employee!!!");
            }
        }

        //Update new employee-------------------------------------------------------------------------------
        public static void UpdateEmployee(Employee e)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    db.Entry<Employee>(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not update employee!!!");
            }
        }

        //Delete member---------------------------------------------------------------------------------------
        public static void DeleteEmployee(Employee e)
        {
            try
            {
                using (var db = new PRN211Context())
                {
                    var e1 = db.Employees.SingleOrDefault(c => c.IdEmp == e.IdEmp);
                    db.Employees.Remove(e1);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not delete employee!!!");
            }
        }

        //Change department------------------------------------------------------------------------------------
        public static void ChangeDepartment(int idEmp, int depnum)
        {
            try
            {
                var emp = new Employee() { IdEmp = idEmp, DepNum = depnum };
                using (var db = new PRN211Context())
                {
                    db.Employees.Attach(emp);
                    db.Entry(emp).Property(e => e.DepNum).IsModified = true;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Can not change department");
            }
        }
    }
}
