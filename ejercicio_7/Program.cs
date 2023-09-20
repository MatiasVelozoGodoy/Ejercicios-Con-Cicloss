using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, mayor = 0, posicion = 0;
            for(int x = 0; x <= 10; x++){
            Console.WriteLine("dame un numero");
            n = int.Parse(Console.ReadLine());
            if(x == 0){
                mayor = n;
                posicion = x;
            }
            else if(n > mayor){
                mayor = n;
                posicion = x;
            }
            
            }
            Console.WriteLine("el numero mas grande es: " + mayor + " y fue ingresado en la posicion " + (posicion + 1));            
        }
    }
} 


// Hacer un programa que solicite 10 números y luego mostrar por pantalla el
// máximo de ellos y la posición en la que fue ingresado.