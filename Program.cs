﻿using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class Program {
        static void Main(string[] args) {
            // This is our employee-getting code now
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }

        static List<Employee> GetEmployees() {
            List<Employee> employees = new List<Employee>();
            while (true) {
                Console.WriteLine("Please enter a first name: (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if (firstName == "") {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.Write("Enter photo url: ");
                string photoUrl = Console.ReadLine();

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }

            return employees;
        }
    }
}