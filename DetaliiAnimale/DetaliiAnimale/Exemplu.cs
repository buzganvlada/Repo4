using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Mamifer mamifer = new Mamifer("Urs ", "Maro");
        mamifer.AfisareDetalii();

        Pasare pasare = new Pasare("Bufniță ", "Zbor silențios");
        pasare.AfisareDetalii();

        Papagal papagal = new Papagal("Amazonian ", "Fluturare", "Salut, Mă cheamă...");
        papagal.AfisareDetalii();
    }
}
