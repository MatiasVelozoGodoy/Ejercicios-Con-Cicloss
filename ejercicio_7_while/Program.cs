using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, con = 1, max,  pm ;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            max = a;
            pm = con;
            while(a != 0){
                if(a > max){
                    max = a;
                    pm = con;
                } 
                Console.WriteLine("dame un numero");
                a = int.Parse(Console.ReadLine());
                con++;
            }
            Console.WriteLine("el numero mas grande es " + max + " y la posicion es " + pm);
        }
    }
}

// Hacer un programa que solicite una lista de números que corta cuando se
// ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
// en la que fue ingresado.