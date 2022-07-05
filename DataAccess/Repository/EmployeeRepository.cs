using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void ChangeDepartment(int idEmp, int depnum) => EmployeeDAO.ChangeDepartment(idEmp, depnum);

        public void DeleteEmployee(Employee employee) => EmployeeDAO.DeleteEmployee(employee);

        public List<Employee> GetEmployeeByEmail(string email) => EmployeeDAO.GetEmployeeByEmail(email);

        public Employee GetEmployeeByID(int id) => EmployeeDAO.GetEmployeeByID(id);

        public List<Employee> GetEmployeeByName(string name) => EmployeeDAO.GetEmployeeByName(name);

        public List<Employee> GetEmployees() => EmployeeDAO.GetAllEmpoyee();

        public void InsertEmployee(Employee employee) => EmployeeDAO.InsertEmployee(employee);

        public Employee Login(string email, string password) => EmployeeDAO.Login(email, password);

        public void UpdateEmployee(Employee employee) => EmployeeDAO.UpdateEmployee(employee);
    }
}
