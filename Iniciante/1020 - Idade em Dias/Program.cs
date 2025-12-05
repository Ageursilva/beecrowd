using System;

class URI
{

    static void Main(string[] args)
    {
        int anos, meses, dias, restoDias;
        int totalDias = int.Parse(Console.ReadLine());

        anos = totalDias / 365;
        restoDias = totalDias % 365;
        meses = restoDias / 30;
        dias = restoDias % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }

}