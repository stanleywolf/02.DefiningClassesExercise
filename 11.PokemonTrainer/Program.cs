using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var trainers = new List<Trainer>();
        string command;


        while ((command = Console.ReadLine()) != "Tournament")
        {
            var tokens = command.Split();

            var trainerName = tokens[0];
            var pokemonName = tokens[1];
            var pokemonElement = tokens[2];
            var pokemonHealth = int.Parse(tokens[3]);

            if (!trainers.Any(t => t.Name == trainerName))
            {
                trainers.Add(new Trainer(trainerName));
            }

            var trainer = trainers.First(t => t.Name == trainerName);
            trainer.AddPokenon(new Pokemon(pokemonName,pokemonElement,pokemonHealth));
        }
        while ((command = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == command))
                {
                    trainer.IncreaseBadges();
                }
                else
                {
                    trainer.ReducePokemondHealth();
                    trainer.RemoveDead();
                }
            }
        }
        trainers.OrderByDescending(t => t.Badges)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}
  