using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeByID(int id);

        List<Employee> SearchEmployeeByID(string id);
        List<Employee> GetEmployeeByName(string name);
        List<Employee> GetEmployeeByEmail(string email);

        Employee GetEmployeeByEmailOne(string email);
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        void ChangeDepartment(int idEmp, int depnum);

        Employee Login(string email, string password);

        Employee CheckEmailExist(string email);

        List<Employee> FilterEmployeeByDep(int iddep);

        List<Employee> FilterEmployeeByPos(int idpos);
    }
}
