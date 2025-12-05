using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int valorEmCentavos = (int)(valor * 100);

        // Notas
        int notas100 = valorEmCentavos / 10000;
        int resto = valorEmCentavos % 10000;

        int notas50 = resto / 5000;
        resto %= 5000;

        int notas20 = resto / 2000;
        resto %= 2000;

        int notas10 = resto / 1000;
        resto %= 1000;

        int notas5 = resto / 500;
        resto %= 500;

        int notas2 = resto / 200;
        resto %= 200;

        // Moedas
        int moedas1 = resto / 100;
        resto %= 100;

        int moedas50 = resto / 50;
        resto %= 50;

        int moedas25 = resto / 25;
        resto %= 25;

        int moedas10 = resto / 10;
        resto %= 10;

        int moedas5 = resto / 5;
        resto %= 5;

        int moedas01 = resto;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{notas100} nota(s) de R$ 100.00");
        Console.WriteLine($"{notas50} nota(s) de R$ 50.00");
        Console.WriteLine($"{notas20} nota(s) de R$ 20.00");
        Console.WriteLine($"{notas10} nota(s) de R$ 10.00");
        Console.WriteLine($"{notas5} nota(s) de R$ 5.00");
        Console.WriteLine($"{notas2} nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moedas1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moedas50} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moedas25} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moedas10} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moedas5} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moedas01} moeda(s) de R$ 0.01");
    }
}