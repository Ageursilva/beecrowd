using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            try
            {
                int M = int.Parse(Console.ReadLine());

                int[] moedas = new int[M];
                for (int i = 0; i < M; i++)
                {
                    moedas[i] = int.Parse(Console.ReadLine());
                }

                int N = int.Parse(Console.ReadLine());

                int soma = 0;
                int indice = M - 1;

                while (indice >= 0)
                {
                    soma += moedas[indice];
                    indice -= N;
                }

                bool ehPrimo = true;

                if (soma <= 1)
                {
                    ehPrimo = false;
                }
                else if (soma == 2)
                {
                    ehPrimo = true;
                }
                else if (soma % 2 == 0)
                {
                    ehPrimo = false;
                }
                else
                {

                    int limite = (int)Math.Sqrt(soma);
                    for (int i = 3; i <= limite; i += 2)
                    {
                        if (soma % i == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }

                if (ehPrimo)
                {
                    Console.WriteLine("You’re a coastal aircraft, Robbie, a large silver aircraft.");
                }
                else
                {
                    Console.WriteLine("Bad boy! I’ll hit you.");
                }
            }
            catch (Exception)
            {
                break;
            }
        }
    }
}