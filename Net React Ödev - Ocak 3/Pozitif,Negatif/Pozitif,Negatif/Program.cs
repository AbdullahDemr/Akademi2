using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0)
        {
            Console.WriteLine("Girilen sayı pozitiftir.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Girilen sayı negatiftir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }
    }
}
