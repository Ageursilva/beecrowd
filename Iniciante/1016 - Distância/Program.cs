using System;

class URI
{

    static void Main(string[] args)
    {
        int distancia = int.Parse(Console.ReadLine());
        double velocidadeX = 60.0;
        double velocidadeY = 90.0;
        double tempoMinutos;

        double diferencaVelocidade = velocidadeY - velocidadeX;

        tempoMinutos = distancia / (diferencaVelocidade / 60);
        Console.WriteLine($"{tempoMinutos} minutos");
    }

}