using ConsoleApp6.Operations;
using System.Reflection;

namespace ConsoleApp6
{
    public abstract class Employee 
    { 
        public string Name { get; set; }
        public abstract string EmployeeType { get; }
    }

    public class Manager : Employee
    {
        public override string EmployeeType => "Manager";
    }

    public class Cashier : Employee
    {
        public override string EmployeeType => "Cashier";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<string, string>();
            var factory = new EmployeeFactory();

            employees.Add("Paulo", "Cashier");
            employees.Add("José", "Manager");

            foreach (var employee in employees)
            {
                var funcao = employee.Value;
                var objeto = factory.Create(funcao);
                objeto.Name = employee.Key;

                Console.WriteLine($"{objeto.Name} - {objeto.EmployeeType}");
            }
        }
    }
}