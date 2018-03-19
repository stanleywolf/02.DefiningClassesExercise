using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());
        
        var member = new Family();
        for (int i = 0; i < input; i++)
        {
            
            var inputArgs = Console.ReadLine().Split();
            var person = new Person();
            person.Name = inputArgs[0];
            person.Age = int.Parse(inputArgs[1]);
            member.AddMembers(person);
            
        }
        var oldest = member.GetOldestMember();
        Console.WriteLine($"{oldest.Name} - {oldest.Age}");
    }
}

