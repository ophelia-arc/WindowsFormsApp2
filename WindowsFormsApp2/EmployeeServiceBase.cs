using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class EmployeeServiceBase
    {
        public abstract bool AddEmployee(Employee employee);
        public abstract Employee FindEmployee(string code);
        public abstract bool AddPayment(
            string employeeCode, string title, double amount);
        public abstract List<Payment> GetEmployeePayments(string employeeCode);
        public abstract List<Employee> GetAllEmployees();
    }

}
