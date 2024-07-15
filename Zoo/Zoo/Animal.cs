public abstract class Animal
{
    public abstract void MakeSound();
    
    public virtual void Eat()
    {
        Console.WriteLine("Animalul mănâncă.");
    }

    public interface IRunnable
    {
        void Run();
    }

}