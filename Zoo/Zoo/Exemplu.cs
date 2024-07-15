using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using static Animal;

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound();
        dog.Eat(); 

        cat.MakeSound();
        cat.Eat(); 

        IRunnable runningDog = new Dog();
        IRunnable runningCat = new Cat();

        runningDog.Run(); 
        runningCat.Run(); 
    }
}
