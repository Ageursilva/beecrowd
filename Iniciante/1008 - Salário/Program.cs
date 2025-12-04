using System;

class URI
{

    static void Main(string[] args)
    {

        int numeroFuncionario = int.Parse(Console.ReadLine());
        int valorHora = int.Parse(Console.ReadLine());
        double horasTrabalhada = double.Parse(Console.ReadLine());
        double salario = valorHora * horasTrabalhada;

        Console.WriteLine($"NUMBER = {numeroFuncionario}");
        Console.WriteLine($"SALARY = U$ {salario:F2}");

    }

}