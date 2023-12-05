using System;
using System.Reflection;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(0, "Employee");
            Employee employee1 = new Employee(1, "Manager");
            Console.WriteLine("Employee1:");
            employee.PrintDetails();
            Console.WriteLine("Employee2:");
            employee1.PrintDetails();
        }
    }
}
