using System;
using System.Collections.Generic;
using System.Text;


public class Cat
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Cat(string name)
    {
        this.name = name;
    }
}
