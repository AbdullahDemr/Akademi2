using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int toplam = sayi1 + sayi2;

        Console.WriteLine("Toplam: " + toplam);
    }
}
