using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Animal;

public class Cat : Animal, IRunnable
{
    public override void MakeSound()
    {
        Console.WriteLine("Pisica miauna");
    }

    public override void Eat()
    {
        Console.WriteLine("Pisica mananca peste");
    }

    public void Run()
    {
        Console.WriteLine("Pisica alearga");
    }
}

