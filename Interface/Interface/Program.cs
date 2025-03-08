public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle { Radius = 5 };
        Console.WriteLine(circle.CalculateArea()); 
    }
}
