using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        for (int i = 1; i <= valor; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}