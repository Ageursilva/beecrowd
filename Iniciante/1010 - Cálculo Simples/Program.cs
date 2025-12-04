using System;

class URI
{

    static void Main(string[] args)
    {

        int codigo1, quantidade1, codigo2, quantidade2;
        double valorUnitario1, valorUnitario2, valorTotal;


        string[] linha1 = Console.ReadLine().Split(' ');
        codigo1 = int.Parse(linha1[0]);
        quantidade1 = int.Parse(linha1[1]);
        valorUnitario1 = double.Parse(linha1[2]);

        string[] linha2 = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(linha2[0]);
        quantidade2 = int.Parse(linha2[1]);
        valorUnitario2 = double.Parse(linha2[2]);

        valorTotal = (quantidade1 * valorUnitario1) + (quantidade2 * valorUnitario2);
        Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"));



    }
}