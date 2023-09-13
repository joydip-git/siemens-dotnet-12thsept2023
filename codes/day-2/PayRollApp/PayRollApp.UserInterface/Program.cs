using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayRollApp.Entities;

namespace PayRollApp.UserInterface
{
    internal class Program
    {
        static int GetNoOfRecords()
        {
            Console.Write("enter no of records to store: ");
            return int.Parse(Console.ReadLine());
        }
        static void PrintMenu()
        {
            Console.WriteLine("\n1. store developer");
            Console.WriteLine("2. store hr");
        }
        static int GetChoice()
        {
            Console.Write("\nenter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static Employee CreateEmployee(int choice)
        {
            Console.Write("\nName: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Basic: ");
            double basic = double.Parse(Console.ReadLine());

            Console.Write("Hra: ");
            double hra = double.Parse(Console.ReadLine());

            Console.Write("Da: ");
            double da = double.Parse(Console.ReadLine());

            Employee employee = null;

            switch (choice)
            {
                case 1:
                    Console.Write("Incentive: ");
                    double incentive = double.Parse(Console.ReadLine());
                    employee = new Developer(id, name, basic, da, hra, incentive);
                    break;

                case 2:
                    Console.Write("Gratuity: ");
                    double gratuity = double.Parse(Console.ReadLine());
                    employee = new Hr(id, name, basic, da, hra, gratuity);
                    break;

                default:
                    break;
            }
            return employee;
        }
        static void StoreEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                PrintMenu();
                int choice = GetChoice();
                Employee employee = CreateEmployee(choice);

                employees[i] = employee;
            }
        }
        private static void PrintSalary(Employee[] employees)
        {
            foreach (Employee item in employees)
            {
                item.CalculateSalary();
                //Console.WriteLine($"Salary of {item.Name} is {item.TotalSalary}");
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            //int records = GetNoOfRecords();
            //Employee[] employees = new Employee[records];
            //StoreEmployees(employees);
            //PrintSalary(employees);

            Employee anilEmployee = new Developer(1, "anil", 1, 1, 1, 1);
            Employee sunilEmployee = new Hr(1, "anil", 1, 1, 1, 1);
            if (anilEmployee.Equals(sunilEmployee))
            {
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("different");
        }
    }
}
