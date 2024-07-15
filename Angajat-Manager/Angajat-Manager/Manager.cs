using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Manager : Angajat
{
    public string Departament { get; set; }

    public Manager(string nume, string departament) : base(nume)
    {
        Departament = departament;
    }

    public override void AfisareDetalii()
    {
        Console.WriteLine($"Managerul {Nume} din departamentul {Departament}");
    }
}
