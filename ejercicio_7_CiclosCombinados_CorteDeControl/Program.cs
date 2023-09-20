using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso, camion = 0, camionAtcual = 0, acuPeso, acuEncominedas, maxEncomienda = 0, conEncomiendas = 0;
            
            Console.WriteLine("dime el peso que quieres agregar al camion");
            peso = int.Parse(Console.ReadLine());
            while (peso > 200){
                Console.WriteLine("error, el peso es demasiado grande, dime el peso que quieres agregar al camion");
                peso = int.Parse(Console.ReadLine());
            }
            while (peso > 0)
            {
                camion++;
                acuPeso = 0;
                acuEncominedas = 0;
                
                while (peso + acuPeso <= 200 && peso  > 0)
                {                    
                    acuPeso += peso;
                    acuEncominedas++;
                    Console.WriteLine("dime el peso que quieres agregar al camion");
                    peso = int.Parse(Console.ReadLine());                    
                }
                conEncomiendas = acuEncominedas;
                Console.WriteLine("El camion " + camion + " tiene un peso de: " +  acuPeso);
                if(conEncomiendas > maxEncomienda){
                    maxEncomienda = conEncomiendas;
                    camionAtcual = camion;
                }
            }
            Console.WriteLine("El camion que mas encomiendas tiene es el camion: " + camionAtcual + " con " + maxEncomienda + " encomiendas");
            Console.WriteLine("la cantidad de camiones que se cargaron fueron " + camion);

        }
    }
}

// Hacer un programa para ingresar los valores de los pesos de distintas
// encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
// ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
// pueden transportar hasta 200 kilos en total.

// Por ejemplo:
// 10, 20, 140,     70, 100,        40, 10, 50, 80,     90, 30, 40,      50, -10.
// Camión 1.        Camión 2           Camión 3            Camión 4        Camión 5

// Se pide determinar e informar:
// a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
// Camión 2: 170kg, etc.).

// b. El número de camión que transporta mayor cantidad de encomiendas
// (en el ejemplo anterior sería el camión 3 con 4 encomiendas).

// c. La cantidad de camiones que se terminaron cargando.