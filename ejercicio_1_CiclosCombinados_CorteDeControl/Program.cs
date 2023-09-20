using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 0;
            for (int x = 0; x < 10; x++)
            {
            int primo, con = 0;
                Console.WriteLine("Dame un numero y te dire cuantos son primos");
                primo = int.Parse(Console.ReadLine());
                for (int i = 1; i <= primo; i++)
                {
                    if (primo % i == 0)
                    {
                        con ++;
                    }
                    
                }
            if (con == 2)
                acum ++;
            }
            Console.WriteLine(acum + " son primos");
        }
    }
}


// Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.