using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private int age;
    private string name;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person()
    {
        
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
    

