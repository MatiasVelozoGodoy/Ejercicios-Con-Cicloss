using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

        int nLote, tF, tFa, M;
        Console.WriteLine("Dame un numero de factura:");
        tF = int.Parse(Console.ReadLine());
        Console.WriteLine("Dame el monto de la factura:");
        M = int.Parse(Console.ReadLine());
        Console.WriteLine("Dame un numero de lote (con 0 sale):");
        nLote = int.Parse(Console.ReadLine());
        while (nLote != 0)
        {
            tFa = tF;
            while (tF == tFa)
            {
                Console.WriteLine("Dame un numero de lote (con 0 sale):");
                nLote = int.Parse(Console.ReadLine());
                Console.WriteLine("Dame el monto de la factura:");
                M = int.Parse(Console.ReadLine());
                Console.WriteLine("Dame un numero de factura:");
                tF = int.Parse(Console.ReadLine());

            }
        }
        Console.WriteLine("Fin del programa");
        }
    }
}

//corte de control