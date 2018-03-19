using System;
using System.Collections.Generic;
using System.Text;



class Car
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }
    private double fuelPerKm;

    public double FuelPerKm
    {
        get { return fuelPerKm; }
        set { fuelPerKm = value; }
    }

    private double distance;

    public double Distance
    {
        get { return distance; }
        set { distance = value; }
    }
    
    public Car(string model, double fuelAmount, double fuelPerKm, double distance = 0)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelPerKm = fuelPerKm;
        this.Distance = distance;
    }

}
