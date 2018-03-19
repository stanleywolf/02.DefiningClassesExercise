using System;


class Program
{
    static void Main(string[] args)
    {
        var startDate = Console.ReadLine();
        var endDate = Console.ReadLine();

        Console.WriteLine(DateModifier.DifferensDateTime(startDate,endDate));
    }
}

