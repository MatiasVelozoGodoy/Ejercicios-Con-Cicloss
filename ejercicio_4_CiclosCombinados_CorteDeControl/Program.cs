using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu, conGrupo = 0;
            Console.WriteLine("dame un numero: (con numero negativo termina)");
            n = int.Parse(Console.ReadLine());

            while (n >= 0) // inicio del  while principal
            {
                Console.WriteLine("dame un numero: (con 0 cambia de grupo)");
                n = int.Parse(Console.ReadLine());
                acu =  0;
                while (n > 0) // inicio del segundo while
                {
                    acu++;
                    Console.WriteLine("dame un numero: (con 0 cambia de grupo)");
                    n = int.Parse(Console.ReadLine());

                }//fin del segundo while

                conGrupo++;

                Console.WriteLine("el grupo " + conGrupo + " tiene " + acu +" numeros");
            }// fin del while principal
            Console.WriteLine("Fin del programa");
        }
    }
}

// Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
// El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.