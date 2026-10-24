using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2
{
    public class EmployeeService : EmployeeServiceBase
    {
        public static List<Employee> Employees = new List<Employee>();

        public override bool AddEmployee(Employee employee)
        {
            if (employee == null || string.IsNullOrWhiteSpace(employee.Code))
            {
                return false;
            }

            if (Employees.Any(e => e.Code.Equals(employee.Code, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            Employees.Add(employee);
            return true;
        }

        public override Employee FindEmployee(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return null;
            }
            return Employees.FirstOrDefault(e => e.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        public override bool AddPayment(string employeeCode, string title, double amount)
        {
            if (amount <= 0 || string.IsNullOrWhiteSpace(employeeCode) || string.IsNullOrWhiteSpace(title))
            {
                return false;
            }

            var employee = FindEmployee(employeeCode);
            if (employee == null)
            {
                return false;
            }

            employee.Payments.Add(new Payment(title, amount));
            return true;
        }

        public override List<Payment> GetEmployeePayments(string employeeCode)
        {
            var employee = FindEmployee(employeeCode);
            if (employee == null)
            {
                return null;
            }

            return employee.Payments;
        }

        public override List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}