using System;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, maxP = 0, minI = 0;
            bool min = false, max = false;
            for(int x = 0; x < 5; x++){
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            if(a % 2 == 0){
                if(!max){
                maxP = a;
            } else if(a > maxP){
                maxP = a;
            }
                
            } else {
                if (!min){
                minI = a;
                min = true;
            } else if (a < minI)
                minI = a;
            }
        }
            Console.WriteLine("el maximo de los pares es " + maxP + " y el minimo de los impares es " + minI);
    }
}
}

// Hacer un programa que solicite 20 números y luego emitir por pantalla el
// máximo de los números pares y el mínimo de los números impares.