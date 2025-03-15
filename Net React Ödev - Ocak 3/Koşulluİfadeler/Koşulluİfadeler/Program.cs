using System;

class Program
{
    static void Main()
    {
        Console.Write("Yakit miktari girin: ");
        int yakitSeviyesi = Convert.ToInt32(Console.ReadLine());

        if (yakitSeviyesi < 15)
        {
            Console.WriteLine("Yakıttan az kaldı, benzin alın!");
        }
        else
        {
            Console.WriteLine("Yeterli yakıt var.");
        }

    }
}
