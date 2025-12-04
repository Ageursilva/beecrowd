using System;

class URI
{

    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        int a = int.Parse(linha1[0]);
        int b = int.Parse(linha1[1]);
        int c = int.Parse(linha1[2]);
        int maiorAB, maior;

        maiorAB = (a + b + Math.Abs(a - b)) / 2;
        maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine($"{maior} eh o maior");
    }

}