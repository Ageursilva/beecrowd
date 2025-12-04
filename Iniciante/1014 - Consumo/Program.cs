using System;

class URI
{

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double medio = x / y;

        Console.WriteLine($"{medio:F3} km/l");

    }

}