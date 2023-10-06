using Encapsulation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Controllers
{
    internal class EmployeeControllers
    {

        EmployeeService employeeService = new EmployeeService();

        public void GetSalary()
        {
            int startSalart = 1000;
            int endtSalart = 2000;

            var result = employeeService.GetEmployeeSalary(startSalart,endtSalart);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }
}
