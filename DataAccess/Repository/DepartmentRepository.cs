using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public void DeleteDepartment(Department department) => DepartmentDAO.DeleteDepartment(department);

        public List<Department> GetAllDepartment() => DepartmentDAO.GetDepartments();

        public Department GetDepartmentByID(int id) => DepartmentDAO.GetDepartmentByID(id);

        public List<Department> GetDepartmentByName(string name) => DepartmentDAO.GetDepartmentByName(name);

        public void InsertDepartment(Department department) => DepartmentDAO.InsertDepartment(department);

        public void UpdateDepartment(Department department) => DepartmentDAO.UpdateDepartment(department);
    }
}
