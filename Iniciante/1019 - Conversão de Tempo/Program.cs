using System;

class URI
{

    static void Main(string[] args)
    {
        int horas, minutos, segundos, resto;
        int totalSegundos = int.Parse(Console.ReadLine());

        horas = totalSegundos / 3600;
        resto = totalSegundos % 3600;
        minutos = resto / 60;
        segundos = resto % 60;


        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }

}
