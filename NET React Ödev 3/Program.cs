
using NET_React_Ödev_3;

public class Program
{
    public static void Main()
    {
        
        Manager manager = new Manager
        {
            Id = 1,
            Name = "Ali",
            Salary = 5000,
            Department = "IT",
            TeamSize = 5
        };

        
        Developer developer = new Developer
        {
            Id = 2,
            Name = "Ahmet",
            Salary = 4000,
            Department = "IT",
            About = "Full-stack developer"
        };

        
        Console.WriteLine($"{manager.Name} Bonus: {manager.CalculateBonus()}");
        Console.WriteLine($"{developer.Name} Bonus: {developer.CalculateBonus()}");
    }
}