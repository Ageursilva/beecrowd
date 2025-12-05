using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int troca, inicio, soma;

        if (x > y)
        {
            troca = x;
            x = y;
            y = troca;
        }

        if ((x + 1) % 2 == 0)
        {
            inicio = x + 2;
        }
        else
        {
            inicio = x + 1;
        }

        soma = 0;


        for (int i = inicio; i < y; i += 2)
        {
            soma += i;
        }

        Console.WriteLine(soma);
    }
}