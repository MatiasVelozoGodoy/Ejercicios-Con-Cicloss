using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, mayor = 0;
            for(int x = 0; x < 10; x++){
            Console.WriteLine("dame un numero");
            n = int.Parse(Console.ReadLine());
            if(x == 0){
                mayor = n;
            }
            else if(n > mayor){
                mayor = n;
            }
            
            }
            Console.WriteLine("el numero mas grande es: " + mayor);            
        }
    }
}

// Hacer un programa que solicite el ingreso de 10 números y que muestre el
// mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

