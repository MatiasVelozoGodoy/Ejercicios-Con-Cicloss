using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0, primo = 1;
            Console.WriteLine("dame un numero");
            n = int.Parse(Console.ReadLine());
            while (primo <= n)
                {
                    if(n % primo == 0)
                    con++;
                    primo++;
                }
                if(con == 2)
                    Console.WriteLine("es primo");
                else
                    Console.WriteLine("no es primo");
                
            
            
        }
    }
}

// Hacer un programa que solicite UN número y luego calcule y emita un cartel
// aclaratorio si el mismo es primo o no es primo.
// Nota: usando While. Ya lo hicimos con FOR, ahora con While.