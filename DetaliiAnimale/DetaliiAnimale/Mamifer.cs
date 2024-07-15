using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
public class Mamifer : Animal

{
    public string CuloareBlana { get; set; }

    public Mamifer(string nume, string culoare) : base(nume)
    {
        CuloareBlana = culoare;
    }

    public override void AfisareDetalii()
    {
        Console.WriteLine($"Mamiferul: {Name}, de culoarea {CuloareBlana}");
    }

}