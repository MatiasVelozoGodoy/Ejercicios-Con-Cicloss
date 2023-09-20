using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0, con = 0;
            for(int x = 0; x < 5; x++){
                Console.WriteLine("Dame una edad: ");
                a = int.Parse(Console.ReadLine());
                if(a > 18){
                    b += a;
                    con++;
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("el promedio de edad es de: " + (b/con));
            Console.WriteLine("---------------------------------------------------");
        }
    }
}

// Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
// de aquellas personas mayores a 18 años.