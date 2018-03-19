using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var nums = int.Parse(Console.ReadLine());
        var departments = new List<Department>();
        for (int i = 0; i < nums; i++)
        {
            var tokens = Console.ReadLine().Split();
            var name = tokens[0];
            var salary = decimal.Parse(tokens[1]);
            var position = tokens[2];
            var depName = tokens[3];
            string email = "n/a";
            int age = -1;

            if (tokens.Length == 6)
            {
                email = tokens[4];
                age = int.Parse(tokens[5]);
            }
            else if (tokens.Length == 5)
            {
                bool isAge = int.TryParse(tokens[4], out age);
                if (!isAge)
                {
                    email = tokens[4];
                    age = -1;
                }
            }           
            if (!departments.Any(d => d.Name == depName))
            {
                Department dep = new Department(depName);
                departments.Add(dep);
            }
            var department = departments.FirstOrDefault(d => d.Name == depName);
            Employee employee = new Employee(name, salary,position,email,age);
            department.AddEmployee(employee);                     
        }
        var hightDep = departments.OrderByDescending(p => p.AverageSalary).First();

        Console.WriteLine($"Highest Average Salary: {hightDep.Name}");

        foreach (var emp in hightDep.Employees.OrderByDescending(a=>a.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }
    }

}

