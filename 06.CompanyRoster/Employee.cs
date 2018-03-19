using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private Department department;
    private string email;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public string Position
    {
        get { return position; }
        set { position = value; }
    }
    public Department Department
    {
        get { return this.department; }
        set { this.department = value; }
    }  
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }   
    public Employee(string name,  decimal salary, string position, string email = "n/a", int age = -1)
    {
        this.Name = name;
        this.Position = position;
        this.Salary = salary;
        this.Email = email;
        this.Age = age;
    }

}

