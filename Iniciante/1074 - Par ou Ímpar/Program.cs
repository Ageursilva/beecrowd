using System;

public class Program
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                string tipo = (X % 2 == 0) ? "EVEN" : "ODD";
                string sinal = (X > 0) ? "POSITIVE" : "NEGATIVE";

                Console.WriteLine($"{tipo} {sinal}");
            }
        }
    }
}