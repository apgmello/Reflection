using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class EmployeeFactory
    {
        private Dictionary<string, Func<Employee>> employeeTypes = new Dictionary<string, Func<Employee>>();

        public EmployeeFactory()
        {
            employeeTypes.Add("Manager", () => new Manager());
            employeeTypes.Add("Cashier", () => new Cashier());
        }

        public Employee Create(string funcao)
        { 
            var strategy = employeeTypes[funcao];

            return strategy.Invoke();
        }
    }
}
