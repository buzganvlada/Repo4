using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pasare : Animal
{
    public string TipZbor { get; set; }

    public Pasare(string nume, string tipZbor) : base(nume)
    {
        TipZbor = tipZbor;
    }

    public override void AfisareDetalii()
    {
        Console.WriteLine($"Pasarea: {Nume}, Tipul de zbor: {TipZbor}");
    }
}