using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Service
{
    internal class EmployeeService
    {
        public Employee[] GetEmployees()
        {
            Employee emp1 = new Employee()
            {
                Name = "Semed",
                Surname = "Huseynov",
                Age = 27,
                Salary = 1460
            };
            Employee emp2 = new Employee()
            {
                Name = "Tunzale",
                Surname = "Memmedova",
                Age = 24,
                Salary = 1870
            };
            Employee emp3 = new Employee()
            {
                Name = "Aqsin",
                Surname = "Veliyev",
                Age = 25,
                Salary = 1500

            };
            Employee emp4 = new Employee()
            {
                Name = "Ilham",
                Surname = "Abasli",
                Age = 19,
                Salary = 849
            };

            return new Employee[] {emp1 , emp2 , emp3 , emp4 };
        }


        public Employee[] GetEmployeeSalary(int startSalary , int endSalary)
        {
            return GetEmployees().Where(n=> n.Salary > startSalary &&  n.Salary < endSalary).ToArray();  

        }
    }
}
