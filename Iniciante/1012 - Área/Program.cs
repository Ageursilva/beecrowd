using System;

class URI
{

    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        double a = double.Parse(linha1[0]);
        double b = double.Parse(linha1[1]);
        double c = double.Parse(linha1[2]);
        double pi = 3.14159;

        double areaTriangulo = (a * c) / 2.0;
        double areaCirculo = pi * c * c;
        double areaTrapezio = ((a + b) * c) / 2.0;
        double areaQuadrado = b * b;
        double areaRetangulo = a * b;




        Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
        Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
        Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
    }

}
