public abstract class Animal
{
    public abstract void Speak();
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Miov");
    }
}

public class Program
{
    public static void Main()
    {
        Cat cat = new Cat();
        cat.Speak(); 
    }
}
