using System;

class URI
{

    static void Main(string[] args)
    {
        double a, b, c, delta, raizDelta, R1, R2;
        string[] valores = Console.ReadLine().Split(' ');
        a = double.Parse(valores[0]);
        b = double.Parse(valores[1]);
        c = double.Parse(valores[2]);

        delta = Math.Pow(b, 2) - (4 * a * c);
        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            raizDelta = Math.Sqrt(delta);

            R1 = (-b + raizDelta) / (2 * a);
            R2 = (-b - raizDelta) / (2 * a);
            Console.WriteLine($"R1 = {R1:F5}");
            Console.WriteLine($"R2 = {R2:F5}");
        }
    }

}