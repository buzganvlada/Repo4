﻿using System;

public class Animal
{
    public string Name { get; set; }
     public Animal(string name)
    {
        Name = name;
    }

    public virtual void AfisareDetalii()
    {
        Console.WriteLine($"Animalul este {Name}");
    }

}