using System;

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');

        int horaInicio = int.Parse(valores[0]);
        int minutoInicio = int.Parse(valores[1]);
        int horaFim = int.Parse(valores[2]);
        int minutoFim = int.Parse(valores[3]);

        int inicioEmMinutos = horaInicio * 60 + minutoInicio;
        int fimEmMinutos = horaFim * 60 + minutoFim;

        int duracaoMinutos;

        if (fimEmMinutos > inicioEmMinutos)
        {
            duracaoMinutos = fimEmMinutos - inicioEmMinutos;
        }
        else
        {
            duracaoMinutos = (24 * 60 - inicioEmMinutos) + fimEmMinutos;
        }

        int horas = duracaoMinutos / 60;
        int minutos = duracaoMinutos % 60;

        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }
}