public class Engine
{
    private int enginePower;

    public int EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }

    public Engine(int enginePower)
    {
        this.EnginePower = enginePower;
    }
}