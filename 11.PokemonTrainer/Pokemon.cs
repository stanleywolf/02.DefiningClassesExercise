using System;
using System.Collections.Generic;
using System.Text;


public class Pokemon
{
    private string name;
    private string element;
    private int health;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public string Element
    {
        get { return element; }
        set { element = value; }
    }  

    public Pokemon(string name, string element, int health)
    {
        this.name = name;
        this.Element = element;
        this.Health = health;
    }
    public void ReduceHealth()
    {
        this.Health -= 10;
    }
}