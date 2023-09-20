using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, menor = 0, posicion = 0;
            for(int x = 0; x < 10; x++){
            Console.WriteLine("dame un numero");
            n = int.Parse(Console.ReadLine());
            if(x == 0){
                menor = n;
                posicion = x;
            }
            else if(n < menor){
                menor = n;
                posicion = x;
            }
            
            }
            Console.WriteLine("el numero mas chico es: " + menor + " y fue ingresado en la posicion " + (posicion + 1));            
        }
    }
} 

// Hacer un programa que solicite 20 números y luego mostrar por pantalla el
// menor de ellos y la posición en la que fue encontrado.