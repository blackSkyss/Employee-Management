using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartment();
        Department GetDepartmentByID(int id);

        List<Department> SearchDepartmentByID(string id);
        List<Department> GetDepartmentByName(string name);
        void InsertDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);

    }
}
