﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }
    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public Trainer()
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
    }

    public void AddPokenon(Pokemon pokemon)
    {
        this.Pokemons.Add(pokemon);
    }

    public void IncreaseBadges()
    {
        Badges++;
    }

    public void ReducePokemondHealth()
    {
        this.Pokemons.ForEach(p => p.ReduceHealth());
    }

    public void RemoveDead()
    {
        this.Pokemons = this.Pokemons
            .Where(p => p.Health > 0)
            .ToList();
    }

    public override string ToString()
    {
        return $"{Name} {Badges} {Pokemons.Count}";
    }
}

