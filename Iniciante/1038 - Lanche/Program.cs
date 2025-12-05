using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        CultureInfo culture = CultureInfo.InvariantCulture;
        string[] entrada = Console.ReadLine().Split(' ');
        int codigo = int.Parse(entrada[0]);
        int quantidade = int.Parse(entrada[1]);
        double total;

        switch (codigo)
        {
            case 1:
                total = 4.00 * quantidade;
                break;
            case 2:
                total = 4.50 * quantidade;
                break;
            case 3:
                total = 5.00 * quantidade;
                break;
            case 4:
                total = 2.00 * quantidade;
                break;
            case 5:
                total = 1.50 * quantidade;
                break;
            default:
                Console.WriteLine("Código Invalido");
                return;
        }
        Console.WriteLine($"Total: R$ {total.ToString("F2", culture)}");
    }

}
