using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }

        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a first name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee.GetName());
            }

            return employees;
        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i =0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}