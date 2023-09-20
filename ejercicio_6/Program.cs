using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m = 0;
            Console.WriteLine("dame un numero");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                m++;
            }
            if(m == 2)
                Console.WriteLine("es primo");
            else
                Console.WriteLine("no es primo");
        }
    }
}

// Hacer un programa que solicite UN número y luego calcule y emita un cartel
// aclaratorio si el mismo es primo o no es primo.
// Nota: un numero es primo cuando es divisible únicamente por 1 y por sí
// mismo.