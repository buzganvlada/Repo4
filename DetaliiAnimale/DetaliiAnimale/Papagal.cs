using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Papagal : Pasare
{
    public string Vocabular { get; set; }

    public Papagal(string nume, string tipZbor, string vocabular) : base(nume, tipZbor)
    {
        Vocabular = vocabular;
    }

    public override void AfisareDetalii()
    {
        Console.WriteLine($"Papagalul: {Name}, Tipul de zbor: {TipZbor}, Vocabular: {Vocabular}");
    }
}
