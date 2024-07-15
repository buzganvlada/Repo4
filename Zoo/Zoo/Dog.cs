using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Animal;

public class Dog : Animal, IRunnable
{
    public override void MakeSound()
    {
        Console.WriteLine("Cainele latra");
    }

    public override void Eat()
    {
        Console.WriteLine("Cainele mananca oase");
    }

    public void Run()
    {
        Console.WriteLine("Cainele alearga"); 
    }
}

