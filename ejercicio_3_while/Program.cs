using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, con = 0;
            Console.WriteLine("dame una edad y cuando pongas una menor de 18 terminare y te mostrare cuantas personas hay");
            edad = int.Parse(Console.ReadLine());
            while (edad > 18)
            {
                con++;
                Console.WriteLine("dame una edad y cuando pongas una menor de 18 terminare y te mostrare cuantas personas hay");
                edad = int.Parse(Console.ReadLine());

            }
            if(con == 0)
                Console.WriteLine("no hay ninguna persona mayor de edad");
            else
                Console.WriteLine("hay " + con + " personas mayores a 18");
        }
    }
}

// Hacer un programa que solicite la edad de un grupo de personas. El programa
// deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
// mostrar por pantalla cuántas personas mayores se registraron.