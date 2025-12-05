using System;

public class Program
{
    public static void Main()
    {
        int NC = int.Parse(Console.ReadLine());

        for (int caso = 1; caso <= NC; caso++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int N = int.Parse(valores[0]);
            int K = int.Parse(valores[1]);

            int sobrevivente = 0;


            for (int i = 1; i <= N; i++)
            {
                sobrevivente = (sobrevivente + K) % i;
            }

            sobrevivente += 1;

            Console.WriteLine($"Case {caso}: {sobrevivente}");
        }
    }
}