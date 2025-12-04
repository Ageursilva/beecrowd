using System;

class URI
{

    static void Main(string[] args)
    {
        int tempoViagem = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        double distanciaPercorrida, litrosNecesarios;
        double consumoVeiculo = 12.0;


        distanciaPercorrida = velocidadeMedia * tempoViagem;
        litrosNecesarios = distanciaPercorrida / consumoVeiculo;


        Console.WriteLine($"{litrosNecesarios:F3}");
    }

}