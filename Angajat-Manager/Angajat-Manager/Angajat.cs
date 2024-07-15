using System;

public class Angajat
{
    public string Nume { get; set; }

    public Angajat(string nume)
    {
        Nume = nume;
    }

    public virtual void AfisareDetalii()
    {
        Console.WriteLine($"Angajatul: {Nume}");
    }
}