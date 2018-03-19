using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string name;
    private Engine enginePower;
    private Cargo cargo;
    private Tire[] tires;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Engine EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }

    public Cargo Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public Tire[] Tires
    {
        get { return tires; }
        set { tires = value; }
    }

    public Car()
    {
        this.Name = name;
        this.EnginePower = enginePower;
        this.Cargo = cargo;
        this.Tires = tires;
    }
    public Car(string name, Engine enginePower, Cargo cargo, Tire[] tires)
    {
        this.Name = name;
        this.EnginePower = enginePower;
        this.Cargo = cargo;
        this.Tires = tires;
    }

}