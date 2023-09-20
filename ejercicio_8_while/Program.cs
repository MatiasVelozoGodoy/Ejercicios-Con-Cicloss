using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {   
            int a, min, sm = 0;
            bool pv = true;
            Console.WriteLine("dame un numero: (con '0' se corta):");
            a = int.Parse(Console.ReadLine());
            min = a;
            while (a != 0)
            {
                if(a < min){
                    sm = min;
                    min = a;
                } else if(!pv){
                    sm = a;
                    pv = true;
                } else if(a < sm)
                    sm = a;
                


            Console.WriteLine("dame un numero: (con '0' se corta):");
            a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el numero mas chico es " + min + " y el segundo es " + sm);
        }
    }
}

// Hacer un programa que solicite una lista de números que corta cuando se
// ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

// if menor a mayor y mayor a la mayoria

