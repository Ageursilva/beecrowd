using System;

class URI
{

    static void Main(string[] args)
    {

        string nomeFuncionario = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());
        double salarioFinal = (salario + (vendas * 0.15));

        Console.WriteLine($"TOTAL = R$ {salarioFinal:F2}");

    }

}