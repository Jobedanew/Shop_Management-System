using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Management_System.Models;

namespace Shop_Management_System.Controllers
{
    internal class EmployeeController
    {
        Employees e = new Employees();

        public void AddEmployee(Employee employee)
        {
            e.AddEmployee(employee);
        }

        public void DeleteEmployee(string employeeId)
        {
            e.DeleteEmployee(employeeId);
        }

        public void UpdateEmployee(Employee employee)
        {
            e.UpdateEmployee(employee);
        }

        public Employee SearchEmployee(string employeeId)
        {
            Employee employee = e.SearchEmployee(employeeId);
            return employee;
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> employeeList = e.GetAllEmployee();
            return employeeList;
        }
    }
}
