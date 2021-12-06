using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class Util {
        public static void PrintEmployees(List<Employee> employees) {

            // Looping through all employees and printing to console
            for (int i =0; i < employees.Count; i++) {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }

        public static void MakeCSV(List<Employee> employees) {

            // Checking if the data folder exists, if not creating one
            if (!Directory.Exists("data")) {
                Directory.CreateDirectory("data");
            }

            using (StreamWriter file = new StreamWriter("data/employees.csv")) {

                // Looping through all employees and adding them to csv file
                for (int i =0; i < employees.Count; i++) {
                    string template = "{0},{1},{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }
        }
    }
}