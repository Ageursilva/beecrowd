using System;

class URI
{

    static void Main(string[] args)
    {
        double raio = int.Parse(Console.ReadLine());

        double pi = 3.14159;
        double volume;
        double raioAoCubo = Math.Pow(raio, 3);
        volume = (4.0 / 3.0) * pi * raioAoCubo;




        Console.WriteLine($"VOLUME = {volume:F3}");
    }

}