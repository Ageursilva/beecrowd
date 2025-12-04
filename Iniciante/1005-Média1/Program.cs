using System;

class URI
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double soma = (a * 3.5) + (b * 7.5);
        double media = soma / 11;


        Console.WriteLine($"MEDIA = {media:F5}");
    }
}