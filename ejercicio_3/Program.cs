using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, positivos = 0;
            for (int x = 0; x < 20; x++)
            {
            Console.WriteLine("dame un numero");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
                positivos++;
            }
            Console.WriteLine("la cantidad de numero positivos son: " + positivos);
        }
    }
}

// Hacer un programa que solicite 20 números y calcule y emita por pantalla
// cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el
// conteo final.