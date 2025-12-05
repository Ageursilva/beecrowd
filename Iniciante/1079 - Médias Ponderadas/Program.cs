using System;

class URI
{

    static void Main(string[] args)
    {

        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < numero; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(valores[0]);
            double valor2 = double.Parse(valores[1]);
            double valor3 = double.Parse(valores[2]);
            double media = (2 * valor1 + 3 * valor2 + 5 * valor3) / 10;
            Console.WriteLine($"{media:f1}");

        }

    }

}