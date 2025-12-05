using System;

public class Program
{
    public static void Main()
    {
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string[] valores = linha.Split(' ');
            uint a = uint.Parse(valores[0]);
            uint b = uint.Parse(valores[1]);

            uint resultado = a ^ b;

            Console.WriteLine(resultado);
        }
    }
}