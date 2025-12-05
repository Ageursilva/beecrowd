using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        int a_original = a;
        int b_original = b;
        int c_original = c;
        int temp;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        if (a > c)
        {
            temp = a;
            a = c;
            c = temp;
        }
        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }

        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Console.WriteLine($"{c}");
        Console.WriteLine();
        Console.WriteLine($"{a_original}");
        Console.WriteLine($"{b_original}");
        Console.WriteLine($"{c_original}");


    }

}