public class Cargo
{
    private string cargoType;

    public string CargoType
    {
        get { return cargoType; }
        set { cargoType = value; }
    }

    public Cargo(string cargoType)
    {
        this.CargoType = cargoType;
    }
}