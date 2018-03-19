using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var nums = int.Parse(Console.ReadLine());

        var person = new List<Person>();
        for (int i = 0; i < nums; i++)
        {
            var argum = Console.ReadLine().Split();
            person.Add(new Person(argum[0],int.Parse(argum[1])));
            
        }
        var orderedPerson = person.Where(p => p.Age > 30)
            .OrderBy(a => a.Name).Select(p => $"{p.Name} - {p.Age}")
            .ToList();
        Console.WriteLine(string.Join(Environment.NewLine,orderedPerson));
    }
}

